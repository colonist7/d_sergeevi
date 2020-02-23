using SEP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEP.Services
{
    public class CalculatorService
    {
        public static CalculatorViewModel Operation(string x, string y, string operation)
        {
            Double result = 0.0;
            var message = "";
            int a = 0;
            int b = 0;

            try
            {
                a = int.Parse(x);

                try
                {
                    b = int.Parse(y);

                    try
                    {
                        switch (operation)
                        {
                            case "add":
                                result = a + b;
                                break;
                            case "sub":
                                result = a - b;
                                break;
                            case "mul":
                                result = a * b;
                                break;
                            case "div":
                                if (b != 0)
                                {
                                    result = (double)a /(double)b;
                                }
                                else
                                {
                                    message = "Null Division Exception";
                                }
                                break;
                            default:
                                message = "Error in operation";
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        message = ex.Message.ToString();
                    }

                }
                catch (Exception ex)
                {
                    message = "Error in value_b";
                }

            } catch (Exception ex)
            {
                message = "Error in value_a";
            }

            string status = "";

            if (message.Equals(""))
            {
                status = "ok";
            } else
            {
                status = message;
            }

            //CalculatorViewModel value_result = new CalculatorViewModel(a.ToString(), b.ToString(), operation, result.ToString(), message);
            CalculatorViewModel value_result = new CalculatorViewModel();
            value_result.value_a = a.ToString();
            value_result.value_b = b.ToString();
            value_result.operation = operation;
            value_result.result = result.ToString();
            value_result.value_result = status;

            return value_result;
        }
    }

}
