using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Sharon Shiri
 * shirish
 * 316393404
 */

namespace Excercise_1
{
    /**
     * SingleMission class.
     * implements from IMission
     */
    public class SingleMission : IMission
    {
        private string myMissionName;
        private FuncDelegate myFunc;
        public event EventHandler<double> OnCalculate; 
        
        /**
         * function name: SingleMission
         * input: FuncDelegate function, string mission
         * output: -
         * function operation: constructor
         */
        public SingleMission(FuncDelegate function, string mission) 
        {
            myMissionName = mission;
            myFunc = function;
        }
        
        
        /**
         * function name: Name
         * input: -
         * output: String myMissionName
         * function operation: get the mission name
         */
        public String Name { get => myMissionName;}
        
        /**
       * function name: Type
       * input: -
       * output: String 
       * function operation: get the mission type - single
       */
        public String Type { get => "Single"; }
        
        /**
    * function name: Calculate
    * input: double value
    * output: double result 
    * function operation: calculate the single mission
    */
        public double Calculate(double value)
        {
            // calculate the function and save the result
            double result = myFunc(value);
            // invoke the event that do the prints
            OnCalculate?.Invoke(this,  result);
            return result;
        }
    }
}
