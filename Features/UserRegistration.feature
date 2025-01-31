Feature: Register new user

  Scenario: Launch Chrome browser & navigate to URL

    Given I navigate to the URL
    Then  I verify that the home page is visible successfully

    When I click on the Signup button
    Then I verify that New User Signup "New User Signup!" is visible

    When I enter name "ENRQA" and email address "ENRQA3@gmail.com"
    And I click the Signup button
    Then I verify that Enter Account Information "Enter Account Information" is visible

    When I fill in details: Title, Name, Email, Password, Date of Birth
    And  I select the checkbox Sign up for our newsletter
    And  I fill in details: First Name, Last Name, Company, Address, Address 2, Country, State, City, Zipcode, Mobile Number
    And  I click the Create Account button
    Then I verify that Account  Created "Account Created!" is visible
    And  I click the Continue button
    Then I verify that Logged in as username "ENRQA" is visible
    When I click the Delete Account button
    Then I verify that Account Deleted "Account Deleted!" is visible
    And  I click the Continue button after account deleted