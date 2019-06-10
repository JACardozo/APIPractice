Feature: Login

Background: sets a base URL
Given I am in  "https://todo.ly/api/" page
And I have entered my credentials "jcardozo2302@gmail.com", "Control123"

@mytag
Scenario: Get all projects
	
	When I GET all projetcs from "projects.json" endpoint 
	Then the status code should be 200
