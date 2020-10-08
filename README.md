# Backlogger
**Capstone Project for Epicodus**  
**By Peter Grimm, 09.25.2020**

## Description
My capstone project for Epicodus. Backlogger is an application which allows users to keep track of their media backlogs. Users can add Movies, TV, video games, and books that they want to experience to their backlog, and prioritize and track their consumption of that media. This project is designed to showcase all the skills that I have developed over the past months working through the curriculum at Epicodus.

## Proposal
[Link to Google Docs](https://docs.google.com/document/d/1j4uo0RTB4lhVTSfvAXzxQLoCHt1r51ZOQs1LgPb1dUg/edit?usp=sharing)

## Specifications
MVP:  
* Users have a media backlog.
* Users can add movies, TV shows, and video games to their backlog.
* Users can filter backlog by media type (movie, TV, video games).
* Users can set the priority of their backlog items.
* Users can mark media items complete when they have finished them.
* Users can search a movie database to add movies
* Users can search a TV database to add TV shows
* Users can search a video game database to add video games

Stretch:
* Users can add books to their backlog
* Users can a books database to add books
* Users can rate media and collective user rating is displayed for rated media.
* Users can review media and user reviews are displayed for reviewed media.    
* Users can browse curated lists of media (IMdB Top 500, AFI's 100 Years 100 Movies, Roger Ebert's Great Movies List, etc.)
* Users can filter by other metadata than media type (genre, year, director, etc.)
* Users are presented links to streaming sites or online marketplaces that feature media they have added
* Users are presented IMdB, Rotten Tomatoes or Metacritic scores for media they have added.

## Setup/Installation Requirements
* .NET Core 2.2 will need to be installed, it can be found here https://dotnet.microsoft.com/download/dotnet-core/2.2
* For Mac users, download MySQL here: https://dev.mysql.com/downloads/file/?id=484914
* For Windows users, download MySQL here: https://dev.mysql.com/downloads/file/?id=484919
* Install MySQL and set the system path, more information on how to do that can be found here: https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql
* Clone the GitHub repository by running `git clone https://github.com/pagrimm/backlogger.git` in the terminal
* Navigate to the newly created `backlogger.solution` folder
* Navigate to the `backlogger` subfolder
* Navigate to the `models` folder and create a `EnvironmentVariables.cs` file
* The contents of the file should be as follows:
```
namespace Backlogger.Models
{
  public static class EnvironmentVariables
  {
    public static string TmdbKey = "your-api-key-here";
  }
}
```
* Acquire an API Key from https://developers.themoviedb.org/3/getting-started/introduction and put it in the `EnvironmentVariable.cs` file you created
* Navigate to the `backlogger.solution\backlogger\` folder
* Run `dotnet restore` to get application dependencies
* Run `dotnet build` to build the application
* Run `dotnet ef database update` to create the application database
* Run `dotnet run` to run the application
* The web app will now be available on `http://localhost:5000/` in your browser

## Technologies Used
C#  
.NET Core 2.2  
ASP.NET Core MVC  
Entity Framework Core 2.2.6  
Pomelo Entity Framework Core 2.2.0

## Legal

Copyright (c) 2020, **_Peter Grimm_**  
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) This software is licensed under the MIT license.
