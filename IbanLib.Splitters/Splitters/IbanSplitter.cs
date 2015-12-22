﻿using System;
using IbanLib.Countries;
using IbanLib.Exceptions;
using IbanLib.Validators;
using IbanLib.Validators.Validators;

namespace IbanLib.Splitters.Splitters
{
    public class IbanSplitter : ASplitter, IIbanSplitter
    {
        private const string Iban = "IBAN";
        private readonly IIbanValidator _ibanValidator;

        public IbanSplitter()
            : this(new IbanValidator())
        {
        }

        public IbanSplitter(IIbanValidator ibanValidator)
        {
            _ibanValidator = ibanValidator;
        }

        /// <summary>
        /// </summary>
        /// <param name="iban"></param>
        /// <returns></returns>
        /// <exception cref="IbanSplitterException"></exception>
        public string GetCountryCode(string iban)
        {
            if (string.IsNullOrWhiteSpace(iban))
            {
                throw new IbanSplitterException(GetErrorMessage(Iban, iban, "Country Code"));
            }

            try
            {
                return iban.Substring(0, 2);
            }
            catch (Exception e)
            {
                throw new IbanSplitterException(GetErrorMessage(Iban, iban, "Country Code"), e);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="country"></param>
        /// <param name="iban"></param>
        /// <returns></returns>
        /// <exception cref="IbanSplitterException"></exception>
        public string GetNationalCheckDigits(ICountry country, string iban)
        {
            ValidateIban(country, iban);

            try
            {
                return iban.Substring(2, 2);
            }
            catch (Exception e)
            {
                throw new IbanSplitterException(GetErrorMessage(Iban, iban, "National Check Digits"), e);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="country"></param>
        /// <param name="iban"></param>
        /// <returns></returns>
        /// <exception cref="IbanSplitterException"></exception>
        public string GetBban(ICountry country, string iban)
        {
            ValidateIban(country, iban);

            try
            {
                return iban.Substring(4);
            }
            catch (Exception e)
            {
                throw new IbanSplitterException(GetErrorMessage(Iban, iban, "BBAN"), e);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="country"></param>
        /// <param name="iban"></param>
        /// <exception cref="IbanSplitterException"></exception>
        private void ValidateIban(ICountry country, string iban)
        {
            if (!_ibanValidator.IsValid(country, iban))
            {
                throw new IbanSplitterException(
                    string.Format(
                        "Parameter IBAN '{0}' for country '{1}' is not valid.",
                        iban,
                        country.ISO3166));
            }
        }
    }
}