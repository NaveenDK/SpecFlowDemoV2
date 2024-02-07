using System;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowDemo.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            Console.WriteLine(number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            Console.WriteLine(number);
            
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            Console.WriteLine(120);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            Console.WriteLine(result);
            if(result == 120)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
                throw new Exception("the value is different");

            }

            // throw new PendingStepException();
            Console.WriteLine(result);
        }

        [When(@"I fill all the mandatatory fields om form")]
        public void WhenIFillAllTheMandatatoryFieldsOmForm(Table table)
        {

            // EmployeeDetails details= table.CreateInstance<EmployeeDetails>();
            var details = table.CreateSet<EmployeeDetails>();

            foreach(EmployeeDetails emp in details)
            {
                Console.WriteLine("The Details of Employee " + emp.Name);
                Console.WriteLine("*************************************");
                Console.WriteLine(  emp.Age);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Phone);
            }
           
            
            
            // throw new PendingStepException();
        }
    }
}


