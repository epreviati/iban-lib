﻿using System;
using IbanLib.Domain.Validators;
using IbanLib.Exceptions;
using IbanLib.Test.Common;
using NUnit.Framework;

namespace IbanLib.Validators.Test
{
    [TestFixture]
    public class ValidatorTestThrowException
    {
        private readonly IBankCodeValidator _bankCodeValidator;
        private readonly IBranchCodeValidator _branchCodeValidator;
        private readonly IAccountNumberValidator _accountNumberValidator;
        private readonly IIbanValidator _ibanValidator;
        private readonly IBbanValidator _bbanValidator;

        public ValidatorTestThrowException()
        {
            _bankCodeValidator = new BankCodeValidator();
            _branchCodeValidator = new BranchCodeValidator();
            _accountNumberValidator = new AccountNumberValidator();
            _ibanValidator = new IbanValidator();
            _bbanValidator = new BbanValidator();
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("-")]
        [TestCase("value")]
        public void AccountNumberValidator_InvalidCountry_Expected_InvalidCountryException(string accountNumber)
        {
            Action action = () => _accountNumberValidator.IsValid(null, accountNumber);
            TestUtil.ExpectedException<InvalidCountryException>(action);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("-")]
        [TestCase("value")]
        public void BankCodeValidator_InvalidCountry_Expected_InvalidCountryException(string bankCode)
        {
            Action action = () => _bankCodeValidator.IsValid(null, bankCode);
            TestUtil.ExpectedException<InvalidCountryException>(action);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("-")]
        [TestCase("value")]
        public void BbanValidator_InvalidCountry_Expected_InvalidCountryException(string bban)
        {
            Action action = () => _bbanValidator.IsValid(null, bban);
            TestUtil.ExpectedException<InvalidCountryException>(action);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("-")]
        [TestCase("value")]
        public void BranchCodeValidator_InvalidCountry_Expected_InvalidCountryException(string branchCode)
        {
            Action action = () => _branchCodeValidator.IsValid(null, branchCode);
            TestUtil.ExpectedException<InvalidCountryException>(action);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("-")]
        [TestCase("value")]
        public void IbanValidator_InvalidCountry_Expected_InvalidCountryException(string iban)
        {
            Action action = () => _ibanValidator.IsValid(null, iban);
            TestUtil.ExpectedException<InvalidCountryException>(action);
        }
    }
}