﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroIdentificacaoFiscalAttribute
{
    class ValidationMessages
    {
        public const String VALIDATION_INTEGER_FORMAT = "NIF numbers are only integers!";
        public const String VALIDATION_EXACT_LENGTH = "NIF number have exactly 9 digits!";
        public const String VALIDATION_INVALID = "The input NIF is invalid!";
    }
}
