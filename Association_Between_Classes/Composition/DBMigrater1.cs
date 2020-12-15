using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    public class DBMigrater
    {

        private readonly Logger _logger;

        // class as parameter in this Composition e.g
        public DBMigrater(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating vlah blah blah ....");
        }
    }
}
