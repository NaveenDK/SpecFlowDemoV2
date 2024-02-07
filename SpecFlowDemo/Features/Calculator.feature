Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowDemo/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Create a new employee with mandatary details
	When I fill all the mandatatory fields om form
	| Name   | Age | Phone       | Email                        |
	| Naveen | 29  | 02040807364 | naveen.kolambage@datacom.com |
	| John | 19  | 13153334 | john@datacom.com |
	| Sam | 39  |  87611233 | sam@datacom.com |
	#And I click the save button
	#Then I should see all the details saved in my application and DB

Scenario Outline: Create a new employee with mandatary details outline
	#And I click the save button
	#Then I should see all the details saved in my application and DB
	When I fill all the mandatatory fields in form <Name>,<Age>, <Phone> and <Email>
	#And I click the save button
	#Then I should see all the details saved in my application and DB
Examples: 
	| Name   | Age | Phone       | Email                        |
	| Naveen | 29  | 02040807364 | naveen.kolambage@datacom.com |
	| John | 19  | 13153334 | john@datacom.com |
	| Sam | 39  |  87611233 | sam@datacom.com |
 

