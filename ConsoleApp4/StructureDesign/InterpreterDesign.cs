using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.StructureDesign
{
    //This is a class that contains information (Input and Output) that is going to be used by the Interpreter.
    public class Context
    {
        //The Expression Property is going to hold the Output
        public string Expression { get; set; }
        //The Date Property is going to hold the Input
        public DateTime Date { get; set; }
        //While Creating the Context Object, we need to send the Input data
        public Context(DateTime date)
        {
            //Initializing the Input Date Property through the Constructor input parameter value
            Date = date;
        }
    }
    //This is going to be an interface that defines the Interpret operation, which must be implemented by each subclass.
    public interface IExpression
    {
        void Evaluate(Context context);
    }

    //This is going to be a Concrete class that implements the Expression Interface.
    //The following Concrete DayExpression Class evaluates the Day grammar
    //That is Replacing DD with the Day from the Input Date Property
    public class DayExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("DD", context.Date.Day.ToString());
        }
    }

    //This is going to be a Concrete class that implements the Expression Interface.
    //The following Concrete MonthExpression Class evaluates the Month grammar
    //That is Replacing MM with the Month from the Input Date Property
    public class MonthExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("MM", context.Date.Month.ToString());
        }
    }

    //This is going to be a Concrete class that implements the Expression Interface.
    //The following Concrete YearExpression Class evaluates the Year grammar
    //That is Replacing YYYY with the Year from the Input Date Property
    public class YearExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("YYYY", context.Date.Year.ToString());
        }
    }

    //This is going to be a Concrete class that implements the Expression Interface.
    //The following Concrete SeparatorExpression Class evaluates the separate grammar
    //That is Replacing space with the - in the Expression string which is going to be our output
    class SeparatorExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace(" ", "-");
        }
    }
}



