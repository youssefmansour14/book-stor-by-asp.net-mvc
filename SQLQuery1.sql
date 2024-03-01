INSERT INTO [dbo].[BOOks] ([Title], [Author], [Description], [CategoryId], [Addedon])
VALUES
    ('To Kill a Mockingbird', 'Harper Lee', 'A classic novel about racial injustice and the loss of innocence in the 1930s.', 1, GETDATE()),
    ('1984', 'George Orwell', 'A dystopian novel set in a totalitarian society where individualism is suppressed.', 1, GETDATE()),
    ('Pride and Prejudice', 'Jane Austen', 'A romantic novel that explores themes of love, class, and societal expectations.', 2, GETDATE()),
    ('The Great Gatsby', 'F. Scott Fitzgerald', 'A story of the decadent and disillusioned Jazz Age in America.', 2, GETDATE()),
    ('To the Lighthouse', 'Virginia Woolf', 'A stream-of-consciousness novel that explores the complexities of human relationships.', 3, GETDATE()),
    ('The Catcher in the Rye', 'J.D. Salinger', 'A coming-of-age novel that follows the rebellious Holden Caulfield.', 3, GETDATE()),
    ('The Lord of the Rings', 'J.R.R. Tolkien', 'An epic fantasy trilogy set in the fictional world of Middle-earth.', 4, GETDATE()),
    ('Harry Potter and the Sorcerer''s Stone', 'J.K. Rowling', 'The first book in the popular Harry Potter series about a young wizard.', 4, GETDATE()),
    ('The Diary of a Young Girl', 'Anne Frank', 'The diary of Anne Frank, a Jewish girl hiding from the Nazis during World War II.', 5, GETDATE()),
    ('Sapiens: A Brief History of Humankind', 'Yuval Noah Harari', 'Explores the history and impact of Homo sapiens on the world.', 6, GETDATE()),
    ('The Power of Now', 'Eckhart Tolle', 'A spiritual guide to living in the present moment and finding inner peace.', 7, GETDATE()),
    ('The Lean Startup', 'Eric Ries', 'A book that offers a methodology for developing startups and launching new products.', 8, GETDATE())