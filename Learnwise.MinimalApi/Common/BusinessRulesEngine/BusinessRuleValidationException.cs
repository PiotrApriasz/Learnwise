namespace Learnwise.MinimalApi.Common.BusinessRulesEngine;

internal class BusinessRuleValidationException(string message) : InvalidOperationException(message);