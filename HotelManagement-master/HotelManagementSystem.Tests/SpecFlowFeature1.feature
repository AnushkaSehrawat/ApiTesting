﻿Feature: Add hotel
	In order to simulate hotel management system
	As api consumer
	I want to be able to add hotel,get hotel details and book hotel

@AddHotel
Scenario Outline: User adds hotel in database by providing valid inputs
	Given User provided valid Id '<id>'  and '<name>'for hotel 
	And Use has added required details for hotel
	When User calls AddHotel api
	Then Hotel with name '<name>' should be present in the response
Examples: 
| id | name   |
| 1  | hotel1 |
| 2  | hotel2 |
| 3  | hotel3 |



Scenario Outline: User add hotel in database and then searches for hotel.
	Given User provided valid Id '<id>'  and '<name>'for hotel 
	And Use has added required details for hotel
	And the user specifies specifies an '<id>'
	When the user calls the hotel api
	Then the hotel with specified hotel '<id>' should be present in the response

	Examples: 
	| id | name |
	|   6 | hotel4 |


Scenario Outline: User adds multiple hotels in the database and then verifies.
	Given User provided valid Id '<id>'  and '<name>'for hotel 
	And Use has added required details for hotel
	When the user calls the api to check weather the enteries are present or no.
	Then the added hotel enteries with all '<id>'should be present in the database.

Examples: 
| id | name    |
| 10 | hotel10 |
| 11 | hotel11 |
| 12 | hotel12 |

	