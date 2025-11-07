# AI Movie Database Web App - Course Project

- **Azure URL:** [[Insert your deployed site link here](https://fall2025-project3-aeburkemper-appservice.azurewebsites.net/)]   


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

## Deployment

The project is deployed on **Azure App Service**.

- **Azure URL:** [[Insert your deployed site link here](https://fall2025-project3-aeburkemper-appservice.azurewebsites.net/)]   

