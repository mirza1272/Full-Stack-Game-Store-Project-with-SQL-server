CREATE DATABASE GameStore;
-- Users Table
CREATE TABLE Users (
    user_id INT PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(50) NOT NULL UNIQUE,
    email VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    role VARCHAR(20) DEFAULT 'customer' CHECK (role IN ('customer', 'admin')),
    created_at DATETIME DEFAULT GETDATE()
);

-- Games Table
CREATE TABLE Games (
    game_id INT PRIMARY KEY IDENTITY(1,1),
    title VARCHAR(100) NOT NULL,
    description TEXT,
    price DECIMAL(10, 2) NOT NULL,
    genre VARCHAR(50),
    platform VARCHAR(50),
    release_date DATE
);

-- Inventory Table
CREATE TABLE Inventory (
    inventory_id INT PRIMARY KEY IDENTITY(1,1),
    game_id INT NOT NULL,
    quantity INT NOT NULL DEFAULT 0,
    last_updated DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (game_id) REFERENCES Games(game_id) ON DELETE CASCADE
);

-- Orders Table
CREATE TABLE Orders (
    order_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL,
    order_date DATETIME DEFAULT GETDATE(),
    total_amount DECIMAL(10, 2) NOT NULL,
    status VARCHAR(20) DEFAULT 'pending' CHECK (status IN ('pending', 'processing', 'shipped', 'delivered', 'cancelled')),
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
);

-- Order_Items Table
CREATE TABLE Order_Items (
    order_item_id INT PRIMARY KEY IDENTITY(1,1),
    order_id INT NOT NULL,
    game_id INT NOT NULL,
    quantity INT NOT NULL,
    unit_price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (order_id) REFERENCES Orders(order_id) ON DELETE CASCADE,
    FOREIGN KEY (game_id) REFERENCES Games(game_id)
);

-- Payments Table
CREATE TABLE Payments (
    payment_id INT PRIMARY KEY IDENTITY(1,1),
    order_id INT NOT NULL,
    payment_date DATETIME DEFAULT GETDATE(),
    amount DECIMAL(10, 2) NOT NULL,
    payment_method VARCHAR(20) CHECK (payment_method IN ('credit_card', 'paypal', 'bank_transfer', 'crypto')),
    status VARCHAR(20) DEFAULT 'pending' CHECK (status IN ('pending', 'completed', 'failed', 'refunded')),
    FOREIGN KEY (order_id) REFERENCES Orders(order_id)
);

CREATE TRIGGER UpdateInventoryTimestamp
ON Inventory
AFTER UPDATE
AS
BEGIN
    UPDATE Inventory
    SET last_updated = GETDATE()
    FROM Inventory
    INNER JOIN inserted ON Inventory.inventory_id = inserted.inventory_id
END

-- for authentication
ALTER TABLE Users
ALTER COLUMN password NVARCHAR(255) NOT NULL;

-- Add salt column for password hashing
ALTER TABLE Users
ADD salt NVARCHAR(100) NOT NULL DEFAULT '';

-- Update the role column to match your schema
ALTER TABLE Users
ADD CONSTRAINT CK_User_Role CHECK (role IN ('customer', 'admin'));



-- For user registration
CREATE PROCEDURE sp_RegisterUser
    @username VARCHAR(50),
    @email VARCHAR(100),
    @password NVARCHAR(255),
    @salt NVARCHAR(100),
    @role VARCHAR(20) = 'customer'
AS
BEGIN
    INSERT INTO Users (username, email, password, salt, role)
    VALUES (@username, @email, @password, @salt, @role);
    
    RETURN SCOPE_IDENTITY();
END;

-- For user authentication
CREATE PROCEDURE sp_AuthenticateUser
    @email VARCHAR(100)
AS
BEGIN
    SELECT user_id, username, password, salt, role 
    FROM Users 
    WHERE email = @email;
END;

-- For checking username/email availability
CREATE PROCEDURE sp_CheckUserExists
    @username VARCHAR(50) = NULL,
    @email VARCHAR(100) = NULL
AS
BEGIN
    SELECT 
        CASE WHEN EXISTS (SELECT 1 FROM Users WHERE username = @username) THEN 1 ELSE 0 END AS UsernameExists,
        CASE WHEN EXISTS (SELECT 1 FROM Users WHERE email = @email) THEN 1 ELSE 0 END AS EmailExists;
END;


-- Users Table
INSERT INTO Users (username, email, password, role) VALUES
('john_doe', 'john@example.com', 'pass123', 'customer'),
('jane_smith', 'jane@example.com', 'pass123', 'customer'),
('mike_jones', 'mike@example.com', 'pass123', 'customer'),
('sarah_lee', 'sarah@example.com', 'pass123', 'customer'),
('david_wilson', 'david@example.com', 'pass123', 'customer'),
('emily_brown', 'emily@example.com', 'pass123', 'customer'),
('robert_taylor', 'robert@example.com', 'pass123', 'customer'),
('lisa_johnson', 'lisa@example.com', 'pass123', 'customer'),
('thomas_miller', 'thomas@example.com', 'pass123', 'customer'),
('jennifer_davis', 'jennifer@example.com', 'pass123', 'customer'),
('william_moore', 'william@example.com', 'pass123', 'customer'),
('amanda_anderson', 'amanda@example.com', 'pass123', 'customer'),
('james_thomas', 'james@example.com', 'pass123', 'customer'),
('jessica_jackson', 'jessica@example.com', 'pass123', 'customer'),
('daniel_white', 'daniel@example.com', 'pass123', 'customer'),
('michelle_martin', 'michelle@example.com', 'pass123', 'customer'),
('christopher_thompson', 'christopher@example.com', 'pass123', 'customer'),
('ashley_garcia', 'ashley@example.com', 'pass123', 'customer'),
('matthew_martinez', 'matthew@example.com', 'pass123', 'customer'),
('admin_user', 'admin@example.com', 'pass123', 'admin');

-- Games Table
INSERT INTO Games (title, description, price, genre, platform, release_date) VALUES
('Elden Ring', 'Action RPG from FromSoftware', 59.99, 'RPG', 'Multi-platform', '2022-02-25'),
('Call of Duty: Modern Warfare II', 'Latest installment in COD series', 69.99, 'FPS', 'Multi-platform', '2022-10-28'),
('God of War: Ragnarok', 'Kratos returns in Norse mythology sequel', 59.99, 'Action-Adventure', 'PlayStation', '2022-11-09'),
('FIFA 23', 'Latest FIFA soccer game', 59.99, 'Sports', 'Multi-platform', '2022-09-30'),
('The Legend of Zelda: Tears of the Kingdom', 'Sequel to Breath of the Wild', 59.99, 'Adventure', 'Nintendo Switch', '2023-05-12'),
('Starfield', 'Bethesda space RPG', 69.99, 'RPG', 'Xbox/PC', '2023-09-06'),
('Cyberpunk 2077', 'Open-world RPG in Night City', 49.99, 'RPG', 'Multi-platform', '2020-12-10'),
('Minecraft', 'Sandbox building game', 29.99, 'Sandbox', 'Multi-platform', '2011-11-18'),
('Grand Theft Auto V', 'Open-world crime game', 39.99, 'Action', 'Multi-platform', '2013-09-17'),
('Red Dead Redemption 2', 'Western open-world adventure', 59.99, 'Action-Adventure', 'Multi-platform', '2018-10-26'),
('The Witcher 3: Wild Hunt', 'Open-world fantasy RPG', 39.99, 'RPG', 'Multi-platform', '2015-05-19'),
('Stray', 'Cat adventure game', 29.99, 'Adventure', 'Multi-platform', '2022-07-19'),
('Hogwarts Legacy', 'Harry Potter universe RPG', 59.99, 'RPG', 'Multi-platform', '2023-02-10'),
('Resident Evil 4 Remake', 'Survival horror remake', 59.99, 'Horror', 'Multi-platform', '2023-03-24'),
('Dead Space Remake', 'Survival horror remake', 59.99, 'Horror', 'Multi-platform', '2023-01-27'),
('Forza Horizon 5', 'Open-world racing game', 59.99, 'Racing', 'Xbox/PC', '2021-11-09'),
('Marvel''s Spider-Man 2', 'Superhero action game', 69.99, 'Action', 'PlayStation', '2023-10-20'),
('Super Mario Bros. Wonder', 'Latest 2D Mario game', 59.99, 'Platformer', 'Nintendo Switch', '2023-10-20'),
('Baldur''s Gate 3', 'D&D based RPG', 59.99, 'RPG', 'Multi-platform', '2023-08-03'),
('Star Wars Jedi: Survivor', 'Sequel to Fallen Order', 69.99, 'Action-Adventure', 'Multi-platform', '2023-04-28');

