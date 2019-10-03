Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities 
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this

@CurrentFailure
Scenario: Calculation of current failure intensity
	Given I have a calculator
    When I have entered "0.02", "10" and "50" into the calculator and press MTBF 
    Then the current failure intensity result should be "3.68"
