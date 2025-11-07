# SemesterYear-Project3-MyBamaUsername

## Overview
This project is a web application built with **ASP.NET Core MVC** for managing movies and actors. The site integrates **AI-generated reviews and social media-style comments** using Azure AI Foundry, and performs **sentiment analysis** with **VaderSharp2**.  

Users can create, read, update, and delete movies and actors, and manage actor-movie relationships. The site displays AI-generated reviews for movies and AI-generated “tweets” for actors, along with their sentiment analysis.

---

## Features

### Movies
- CRUD operations: Create, Read, Update, Delete
- Title, Genre, Year, Poster (stored as byte[])
- IMDB link
- AI-generated reviews with sentiment analysis

### Actors
- CRUD operations
- Name, Gender, Age, Photo (stored as byte[])
- IMDB link
- AI-generated tweets with sentiment analysis

### Actor-Movie Relationships
- Manage relationships between actors and movies
- Prevents duplicate entries
- Displays related movies for actors and related actors for movies

### AI Integration
- Azure AI Foundry for text generation
- VaderSharp2 for sentiment analysis

### UI & UX
- Fully styled with custom CSS
- DataTables integration for enhanced table management (optional bonus)
- Responsive design

---

## Setup Instructions

### Configure Azure AI Foundry API
- Get Target URI and Key from deployed model.
- Store API key in **.NET Secret Manager**.

### Configure SQL Database
- Update `appsettings.json` with your connection string.
- Store credentials in Secret Manager.
- Run migrations to create the database.

### Install required NuGet packages
- `Azure.AI.OpenAI`
- `VaderSharp2`
- `Microsoft.EntityFrameworkCore.SqlServer` (if using SQL Server)

### Build and Run
- Build and run the project in **Visual Studio**.

---

## Deployment

The project is deployed on **Azure App Service**.

- **Azure URL:** [Insert your deployed site link here]  
- **GitHub Repository:** [Insert your GitHub repo link here]  

---

## Screenshots

**Home Page**  
![Home Page](path/to/screenshot1.png)

**Movie Details with AI Reviews**  
![Movie Details](path/to/screenshot2.png)

**Actor Details with AI Tweets**  
![Actor Details](path/to/screenshot3.png)

**Actor-Movie Relationships**  
![Actor-Movie Relationships](path/to/screenshot4.png)

---

## Notes

- All external resources use **SRI hashes**.
- The application prevents duplicate relationships and handles deletion safely.
- Secrets (API keys, database credentials) are stored securely using the **.NET Secret Manager**.
