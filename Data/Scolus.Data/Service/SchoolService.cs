using Scolus.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scolus.Data.Entities;
using System.Data.Entity.Validation;
using Scolus.Data.Attribute;

namespace Scolus.Data.Service
{
    public class SchoolService : ISchoolService
    {
        private readonly ScolusDbContext conn;
        public SchoolService()
        {
            conn = new ScolusDbContext();
        }

        [UpdateEntityLogger("School", CUD.Create)]
        public Response Create(School entity)
        {
            var response = new Response();
            try
            {
                entity.CreatedOn = DateTime.UtcNow;
                entity.UpdatedOn = DateTime.UtcNow;
                conn.Schools.Add(entity);
                conn.SaveChanges();
                response.Success = true;
                response.ReferenceID = int.Parse(entity.ReferenceId);
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        var errMsg = string.Format("Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                        response.Messages.Add(errMsg);
                    }
                }
            }
            catch (Exception e)
            {
                response.Messages.Add(e.Message);
            }
            return response;
        }

        [UpdateEntityLogger("School", CUD.Delete)]
        public Response Delete(int entityId)
        {
            var response = new Response();
            try
            {
                var _entity = conn.Schools.Where(i => i.SchoolId == entityId).FirstOrDefault();
                if (_entity != null)
                {
                    conn.Schools.Remove(_entity);
                    conn.SaveChanges();
                    response.Success = true;
                    response.ReferenceID = entityId;
                }
                else
                {
                    response.Messages.Add("school id not found");
                }

            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        var errMsg = string.Format("Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                        response.Messages.Add(errMsg);
                    }
                }
            }
            catch (Exception e)
            {
                response.Messages.Add(e.Message);
            }
            return response;
        }

        [UpdateEntityLogger("School",CUD.Update)]
        public Response Update(School entity)
        {
            var response = new Response();
            try
            {
                var _entity = conn.Schools.Where(i => i.SchoolId == entity.SchoolId).FirstOrDefault();
                if(_entity != null)
                {
                    _entity.Description = entity.Description;
                    _entity.Name = entity.Name;
                    _entity.Type = entity.Type;
                    _entity.UpdatedOn = DateTime.UtcNow;
                    conn.SaveChanges();
                    response.Success = true;
                    response.ReferenceID = entity.SchoolId;
                } else
                {
                    response.Messages.Add("school id not found");
                }

            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        var errMsg = string.Format("Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                        response.Messages.Add(errMsg);
                    }
                }
            }
            catch (Exception e)
            {
                response.Messages.Add(e.Message);
            }
            return response;
        }


    }
}
