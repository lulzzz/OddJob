﻿using System;
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace OddJob
{
    public class JobCreationExeption : Exception
    {
        public JobCreationExeption()
        {
        }

        public JobCreationExeption(string message) : base(message)
        {
        }

        public JobCreationExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected JobCreationExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
    public static class JobCreator
    {
        public static OddJob Create<T>(Expression<Action<T>> jobExpr)
        {
            var _jobExpr = jobExpr;
            var TypeExecutedOn = typeof(T);//jobExpr.Parameters[0].Type;

            var argProv = (_jobExpr.Body as MethodCallExpression).Arguments;

            var argCount = argProv.Count;
            object[] _jobArgs = new object[argCount];
            for (int i = 0; i < argCount; i++)
            {
                var theArg = argProv[i];
                if (theArg is ConstantExpression)
                {
                    _jobArgs[i] = (theArg as ConstantExpression).Value;
                }
                else if (theArg is MemberExpression)
                {
                    _jobArgs[i] = Expression.Lambda(theArg).Compile().DynamicInvoke();
                }
                else if (theArg is MemberInitExpression)
                {
                    _jobArgs[i] = Expression.Lambda(theArg).Compile().DynamicInvoke();
                }
                else if (theArg is MethodCallExpression)
                {
                    try
                    {
                        _jobArgs[i] = Expression.Lambda(theArg).Compile().DynamicInvoke();
                    }
                    catch (Exception ex)
                    {
                        throw new JobCreationExeption(
                            "Couldn't derive value from job! Please use variables whenever possible and avoid methods that take parameters", ex);
                    }
                }
                else
                {
                    throw new JobCreationExeption(
                        "Couldn't derive value from job! Please use variables whenever possible and avoid methods that take parameters");
                }
         
            }
            var moarInfo = ((MethodCallExpression)_jobExpr.Body).Method.Name;
            var methodName = typeof(T).GetMethod(moarInfo);
            return new OddJob(methodName.Name, _jobArgs, TypeExecutedOn);
        }
    }
}