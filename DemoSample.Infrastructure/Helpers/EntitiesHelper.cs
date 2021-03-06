﻿using DemoSample.Core.Dtos;
using DemoSample.Domain.EF.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSample.Infrastructure.Helpers
{
    public static class EntitiesHelper
    {
        public static TransactionDto ToTransactionDto(this Transaction transaction) => new TransactionDto
        {
            Id = transaction.TransactionIdentifier,
            Payment = $"{transaction.Amount} {transaction.CurrencyCode}",
            Status = TransactionDto.GetStatus(transaction.Status)
        };

        public static IEnumerable<TransactionDto> ToTransactionDtos(this IEnumerable<Transaction> transactions) => transactions.Select(x => x.ToTransactionDto());
    }
}
