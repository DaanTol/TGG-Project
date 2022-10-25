using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using TGG_Model;

namespace TGG_DAL
{
    public class ResetPasswordDAO : BaseDAO
    {
        public ResetPasswordDAO() : base(TGGCollections.ValidationCodes) { }
        //add to db so the user can use validationcodes they might've missed
        public void AddValidationCodes(TGGValidation validationCode)
        {
            BsonDocument bsonDoc = validationCode.ToBsonDocument();
            BsonSerializer.Deserialize<TGGValidation>(CreateOperation(new List<BsonDocument>() { bsonDoc }).First());
        }
        //check if validation is in db
        public bool CheckValidationByElement(BsonElement filterElement, params BsonElement[] extraFilterElements)
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq(filterElement.Name, filterElement.Value);
            foreach (BsonElement element in extraFilterElements)
            {
                filter &= Builders<BsonDocument>.Filter.Eq(element.Name, element.Value);
            }
            if (ReadValidationsDB(ReadOperation(filter)).Count == 0)
            {
                return false;
            }
            return true;
        }
        //get list of validations
        private List<TGGValidation> ReadValidationsDB(List<BsonDocument> filter)
        {
            List<TGGValidation> results = new List<TGGValidation>();

            foreach (BsonDocument bsonDoc in filter)
                results.Add(BsonSerializer.Deserialize<TGGValidation>(bsonDoc));
            return results;
        }
    }
}
