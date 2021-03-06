﻿using System;
using System.Collections.Generic;

namespace Agency.RepositoryInterface
{
    public interface ITicketAgentRepository
    {
        IEnumerable<ITicketAgent> GetTickets(int agentId, DateTime departureDate, int numRowPerPage = 10, int page = 1);
    }
}
