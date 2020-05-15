# ZadaniaRozne-Testowane

# App Test using NUnit
> Testing c# application with NUnit Framework in Visual Studio.
## Table of contents
* [General info](#general-info)
* [Screenshots](#screenshots)
* [Case description](#Description)
* [Technologies](#technologies)
* [Setup](#setup)
* [Status](#status)
* [Contact](#contact)

## General info
> The application i am testing here was a project for OOP C# lessons. 
> In the app I was supposed to create a hospital object with doctors objects as hospital workers and patients  objects assigned to them.
> There was alot lof logic which could be tested so I took advantage of that fact.
> I used NUnit framework for testing purposes.
> The application contains classes:

* Przychodnia (eng. clinic)
* Pacjent (eng. patient)
* Lekarz (eng. doctor)
* Choroba (eng. disease)
> All of the above cases were tested.
> There are 38 tests overall.
> Especially interesting case was with groupAllPacjenci function within Przychodnia class, from which i will put screenshots of and describe briefly below.


## Screenshots
### Tested function
![image.png](https://i.postimg.cc/Qxn1cppn/image.png)
### Test script
![image.png](https://i.postimg.cc/TYqY6GPj/image.png)

## Description
> The function itself is supposed to group patients based on their condition (number of diseases they have), and put them into proper list of patients with said condition.
> There are 3 lists of patients which are called accordingly to their condition state.
* lekkoChorzy - slightly ill
* niezleChorzy - seriously ill
* tragedia - on the edge of death
> As said before each of those are separate lists.
> Because of that fact a list of lists had to be created in order to check in which one of those the patient will be added within the current test case.
## Technologies
* C# - version 7.1
* NUnit Framework - version 3.0


## Setup
To run this test Project, You need to have:

* Visual Studio with c# environmet
* NUnit
* NUnit3TestAdapter


## Status
Project is: Done

## Contact
### Feel free to contact me on:

[Github](https:/www.github.com/xyanteos)

### The tested project was created in collaboration with:
* [Mateusz](https://github.com/mati9980)
* [Maksymilian]()
* [Przemysław]()
