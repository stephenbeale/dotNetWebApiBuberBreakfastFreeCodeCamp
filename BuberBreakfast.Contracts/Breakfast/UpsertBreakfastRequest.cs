using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Upsert is IF exists then update, else insert new row with data
namespace BuberBreakfast.Contracts.Breakfast
{
    public record UpsertBreakfastRequest(
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        List<string> Savoury,
        List<string> Sweet
        );
}
