using Day14.Context;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14.BLL
{
    public class PublisherManager
    {
        
            static pubsContext context = new();

            public static List<PublisherWithID> GetPublisherNamesWithIDs()
            {
                try
                {
                    //context.Publishers.Load();
                    return context.Publishers.Select(i => new PublisherWithID { PubId = i.PubId, PubName = i.PubName }).ToList();

                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.Message);
                    return new();
                }
            }

        }
        public class PublisherWithID
        {
            public required string PubId { get; set; }
            public required string PubName { get; set; }
        }
    }
