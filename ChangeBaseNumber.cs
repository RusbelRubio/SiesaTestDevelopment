using System;

namespace ChangeBaseDefinition
{
    /// <summary>
    /// Base Class for Change number base
    /// </summary>
    public class ChangeBaseNumber
    {
        #region Attributes Class
        private string _ValueInBase = String.Empty;
        #endregion
        #region Methods Public
        public string ChangedBase(int Number, int Base)
        {
            var Quotient = Number / Base;
            var Modulus = Number % Base;

            if (Base < 2 || Base > 16)
                throw new Exception("Value for base is not functional");
            if (Quotient < Base)
                return Quotient.ToString() + Modulus.ToString();
            else
            {
                _ValueInBase += ChangedBase(Quotient, Base);
                return _ValueInBase + Modulus.ToString();
            }
        }
        #endregion
    }
}
