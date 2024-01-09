using DemoCodedWorkFlow.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace DemoCodedWorkFlow
{
    public class UiBankLoanApplication : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
            Log("Hello from coded workflow");
        var LoginScreen = uiAutomation.Open("LoginScreen");
            LoginScreen.Click("ApplyLoanElement");
            //create a different screen for loans
            var LoanScreen = uiAutomation.Attach("LoanScreen");
            LoanScreen.Click("ApplyLoanButton");
            var AppScreen = uiAutomation.Attach("ApplicationScreen");
            AppScreen.TypeInto("Email Address", "manaswinikasturi@uipath.com");
            AppScreen.TypeInto("Loan Amount","2000");
            AppScreen.SelectItem("Loan Term", "5");
            AppScreen.TypeInto("Yearly Income", "12000");
            AppScreen.TypeInto("Age", "22");
            AppScreen.Click("Submit");
            
            var LoanIDScreen = uiAutomation.Attach("LoanIDScreen");
            var LoanID = LoanIDScreen.GetText("LoanID");
            Log(LoanID);
            
            
            
            
            
        }
          
    }
}