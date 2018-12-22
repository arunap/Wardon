using System;
using System.Collections.Generic;
using System.Text;

namespace Wardon.Domain.DataMapper
{
    public interface IDataMapper<Source, Target>
    {
        Target Map(Source entry);
        List<Target> Map(List<Source> entries);
    }
}
