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
    public delegate double FuncDelegate(double x);
    /**
     * FunctionsContainer class.
     */
    public class FunctionsContainer
    {
       
        private Dictionary<string, FuncDelegate> functionsDictionary = new Dictionary<string, FuncDelegate>();

        public FuncDelegate this[string funcName]
        {
           // get the function from the dictionary
            get
            {
                // if the key does not exists in the dictionary
                if (!functionsDictionary.ContainsKey(funcName))
                {
                    // create lambda function that return the same value
                    functionsDictionary[funcName] = val => val;
                }
                // return the function
                return functionsDictionary[funcName];
            }
            // set the function in the dictionary
            set { functionsDictionary[funcName] = value; }
        }

        /**
     * function name: getAllMissions
     * input: -
     * output: List<String> 
     * function operation: return list of names of mission
     */
        public List<String> getAllMissions()
        {
            List<String> listMissionsNames = new List<String>();
            // add the names of the mission to list
            foreach (var func in functionsDictionary)
            {
                listMissionsNames.Add(func.Key);
            }
            // return the list
            return listMissionsNames;

        }
    }
}