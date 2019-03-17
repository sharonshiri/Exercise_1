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
     * ComposedMission class.
     * implements from IMission
     */
    public class ComposedMission : IMission
    {
        private string myMissionName;
        private List<FuncDelegate> listMissions = new List<FuncDelegate>();
        public event EventHandler<double> OnCalculate; 
        
        /**
        * function name: ComposedMission
        * input: string mission
        * output: -
        * function operation: constructor
        */
        public ComposedMission(string mission)
        {
            myMissionName = mission;
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
      * function operation: get the mission type - Composed
      */
        public String Type { get => "Composed"; }

        /**
    * function name: Add
    * input: FuncDelegate func
    * output: ComposedMission this 
    * function operation: add mission to the list of missions and return this (for chain adding)
    */
        public ComposedMission Add(FuncDelegate func) {
            listMissions.Add(func);
            return this;
        }
        
        /**
         * function name: Calculate
         * input: double value
         * output: double result
         * function operation: calculate the missions in the mission list
         */
        public double Calculate(double value)
        {
            // calculate the function and save the result, send the current update result to next mission
            double result = value;
            foreach (var f in listMissions) {
                result = f(result);
            }
            // invoke the event that do the prints
            OnCalculate?.Invoke(this,  result);
            return result;
        }
        
    }
}
