﻿using Mc2.CrudTest.Framework.Domain.ValueObjects;

namespace Mc2.CrudTest.Core.Domain.Customers.ValueObjects
{
    public class BankAccountNumber : BaseValueObject<BankAccountNumber>
    {
        public string Value { get; private set; }
        public static BankAccountNumber FromString(string value) => new BankAccountNumber(value);
       
        private BankAccountNumber() { }

        public BankAccountNumber(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("BankAccountNumber is required.", nameof(value));
            }
            Value = value;
        }
        public override int ObjectGetHashCode() => Value.GetHashCode();
        public override bool ObjectIsEqual(BankAccountNumber otherObject) => Value == otherObject.Value;
        public static implicit operator string(BankAccountNumber bankAccountNumber) => bankAccountNumber.Value;
    }
}
