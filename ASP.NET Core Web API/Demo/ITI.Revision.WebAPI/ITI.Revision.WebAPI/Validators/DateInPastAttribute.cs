using System.ComponentModel.DataAnnotations;

namespace ITI.Revision.WebAPI.Validators
{
    public class DateInPastAttribute:ValidationAttribute
    {
        //public override bool IsValid(object? value)
        //    => value is DateOnly date && date < DateOnly.Now;   //DateOnly doesn't contain Now

        //ILogger logger;
        //public DateInPastAttribute(ILogger logger)
        //{
        //    this.logger = logger;
        //}

        public DateInPastAttribute()
        { }

        public override bool IsValid(object? value)
        {
            if (value is DateOnly date)
            {
                //logger.LogWarning("Date In Past Attribute has been Fired !");
                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
                return date < currentDate;
            }
            return false;
        }

    }
}
