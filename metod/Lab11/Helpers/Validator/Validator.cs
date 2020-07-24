using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Helpers.Validator
{
    using DataValidator = System.ComponentModel.DataAnnotations.Validator;
    public class Validator
    {
        public Validator()
        {
            Results = new List<ValidationResult>();
        }

        public List<ValidationResult> Results { get; private set; }
        private ValidationContext _context;

        private void Reset()
        {
            Results.Clear();
            _context = null;
        }
        public bool IsValid<T>(T model)
        {
            Reset();
            _context = new ValidationContext(model);
            return DataValidator.TryValidateObject(model, _context, Results, true);
        }
        
    }
}
