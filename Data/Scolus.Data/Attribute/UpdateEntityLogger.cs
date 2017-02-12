using System;
using System.Reflection;
using PostSharp.Aspects;
using PostSharp.Extensibility;
using PostSharp.Serialization;
using Newtonsoft.Json;
using Scolus.Data.Entities;

namespace Scolus.Data.Attribute
{

    [PSerializable]
    public sealed class UpdateEntityLogger : MethodInterceptionAspect
    {

        private readonly string tableName;
        private readonly CUD type;
        public UpdateEntityLogger(string tableName, CUD type)
        {
            this.tableName = tableName;
            this.type = type;
        }

        #region Build-Time Logic

        public UpdateEntityLogger()
        {
        }

        public override bool CompileTimeValidate(MethodBase method)
        {
            // TODO: Check that the aspect has been applied on a proper method.

            if (false)
            {
                Message.Write(method, SeverityType.Error, "MY001", "Cannot apply UpdateEntityLogger to method '{0}'.", method);
                return false;
            }

            return true;
        }

        public override void CompileTimeInitialize(MethodBase method, AspectInfo aspectInfo)
        {
            // TODO: Initialize any instance field whose value only depends on the method to which the aspect is applied.
        }

        #endregion

        public override void RuntimeInitialize(MethodBase method)
        {
            // This method executes once at run time.
        }

        public override void OnInvoke(MethodInterceptionArgs args)
        {
            if (args.Arguments.Count > 0)
            {
                using (var conn = new ScolusDbContext())
                {
                    string data = JsonConvert.SerializeObject(args.Arguments[0]);
                    var log = new EntityDataUperLogger()
                    {
                        CreatedDate = DateTime.UtcNow,
                        Data = data,
                        TableName = this.tableName,
                        Type = this.type
                    };
                    conn.EntityDataUperLoggers.Add(log);
                    conn.SaveChanges();
                }
            }
            base.OnInvoke(args);
        }


    }
}