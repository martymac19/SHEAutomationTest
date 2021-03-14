Feature: SheTest
    Login to application
    Enter new record
    Save and close
    Delete record
    Verify record deleted
 
@SHETest
Scenario: SHE Automation Test
    Given I open the SHEdevelopment homepage
    Then I successfully login
    Then I navigate to Air Emissions module
    Then I click new record
    Then I enter date and description
    Then I save and close
    Then I delete the record
    And verify record successfully deleted
    Then log out