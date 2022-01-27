# P2 Proposal - Drawing vs Google (Droogle)

## Overview

Droogle is a web-based application to test your drawing skills against Google Vision API. Sign up to get started and save your past creations and compare your results against others!

## Tables

User table, for username, password, personal information
Wall Post Table, for keywords to guess and amount of likes, links to drawings table
Drawings Table, to keep track of user's drawings
Comment Table, tracks comments of specific wall posts for each drawing

## User Stories

As a user I should be able to sign up and log in
As a user I should be able to make a new drawing and submit it to google vision
As a user I should be able to receive google vision's response on my drawings
As a user I should be able to see my past drawings and scores
As a user I should be able to see, like, and comment on other people's drawings
As an admin I should be able to add new wall posts for keywords to guess
As an admin I should be able to delete user drawings or comments

Stretch Goals:
*As a user I should be able to go head to head against another user
*Scoreboard

## Tech Stack

C#
ASP.NET Web API (for BE)
Angular w/ Typescript (for FE)
XUnit, Moq, Sonar cloud for testing and code analysis
AWS for hosting
Github action for CI/CD pipeline (or really any devops tool)
AWS RDS or any kind of hosted SQL DB for our DB (for free tool, use ElephantSQL)
EF Core for Object Relational Mapper
Logging with Microsoft Extensions Logging (with SeriLog)

