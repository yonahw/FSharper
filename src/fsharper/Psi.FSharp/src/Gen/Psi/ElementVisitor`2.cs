//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
namespace JetBrains.ReSharper.Psi.FSharp {
  public abstract partial class ElementVisitor<TContext, TReturn>  {
    public virtual TReturn VisitElement ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.Tree.IElement param, TContext context) {
      return default(TReturn);
    }
    public virtual TReturn VisitFSharpFile ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IFSharpFile FSharpFileParam, TContext context) {
      return VisitElement (FSharpFileParam, context);
    }
    public virtual TReturn VisitAlgebraicTypeRepresentation ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IAlgebraicTypeRepresentation algebraicTypeRepresentationParam, TContext context) {
      return VisitElement (algebraicTypeRepresentationParam, context);
    }
    public virtual TReturn VisitAndExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IAndExpression andExpressionParam, TContext context) {
      return VisitElement (andExpressionParam, context);
    }
    public virtual TReturn VisitApplicationExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IApplicationExpression applicationExpressionParam, TContext context) {
      return VisitElement (applicationExpressionParam, context);
    }
    public virtual TReturn VisitArrayExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IArrayExpression arrayExpressionParam, TContext context) {
      return VisitElement (arrayExpressionParam, context);
    }
    public virtual TReturn VisitArrayPattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IArrayPattern arrayPatternParam, TContext context) {
      return VisitElement (arrayPatternParam, context);
    }
    public virtual TReturn VisitArrayType ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IArrayType arrayTypeParam, TContext context) {
      return VisitElement (arrayTypeParam, context);
    }
    public virtual TReturn VisitAsValuePattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IAsValuePattern asValuePatternParam, TContext context) {
      return VisitElement (asValuePatternParam, context);
    }
    public virtual TReturn VisitAssertExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IAssertExpression assertExpressionParam, TContext context) {
      return VisitElement (assertExpressionParam, context);
    }
    public virtual TReturn VisitAssignExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IAssignExpression assignExpressionParam, TContext context) {
      return VisitElement (assignExpressionParam, context);
    }
    public virtual TReturn VisitAssignFieldExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IAssignFieldExpression assignFieldExpressionParam, TContext context) {
      return VisitElement (assignFieldExpressionParam, context);
    }
    public virtual TReturn VisitAttribute ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IAttribute attributeParam, TContext context) {
      return VisitElement (attributeParam, context);
    }
    public virtual TReturn VisitAttributeReference ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IAttributeReference attributeReferenceParam, TContext context) {
      return VisitElement (attributeReferenceParam, context);
    }
    public virtual TReturn VisitBinaryAddExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBinaryAddExpression binaryAddExpressionParam, TContext context) {
      return VisitElement (binaryAddExpressionParam, context);
    }
    public virtual TReturn VisitBinaryMultExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBinaryMultExpression binaryMultExpressionParam, TContext context) {
      return VisitElement (binaryMultExpressionParam, context);
    }
    public virtual TReturn VisitBinaryPowerExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBinaryPowerExpression binaryPowerExpressionParam, TContext context) {
      return VisitElement (binaryPowerExpressionParam, context);
    }
    public virtual TReturn VisitBinding ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IBinding bindingParam, TContext context) {
      return VisitElement (bindingParam, context);
    }
    public virtual TReturn VisitBindingPattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBindingPattern bindingPatternParam, TContext context) {
      return VisitElement (bindingPatternParam, context);
    }
    public virtual TReturn VisitBindingValue ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IBindingValue bindingValueParam, TContext context) {
      return VisitElement (bindingValueParam, context);
    }
    public virtual TReturn VisitBracketedExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBracketedExpression bracketedExpressionParam, TContext context) {
      return VisitElement (bracketedExpressionParam, context);
    }
    public virtual TReturn VisitBracketedFieldValueExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBracketedFieldValueExpression bracketedFieldValueExpressionParam, TContext context) {
      return VisitElement (bracketedFieldValueExpressionParam, context);
    }
    public virtual TReturn VisitBracketedPattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBracketedPattern bracketedPatternParam, TContext context) {
      return VisitElement (bracketedPatternParam, context);
    }
    public virtual TReturn VisitComparisonExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IComparisonExpression comparisonExpressionParam, TContext context) {
      return VisitElement (comparisonExpressionParam, context);
    }
    public virtual TReturn VisitConstantExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IConstantExpression constantExpressionParam, TContext context) {
      return VisitElement (constantExpressionParam, context);
    }
    public virtual TReturn VisitConstantPattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IConstantPattern constantPatternParam, TContext context) {
      return VisitElement (constantPatternParam, context);
    }
    public virtual TReturn VisitConstructorDeclaration ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IConstructorDeclaration constructorDeclarationParam, TContext context) {
      return VisitElement (constructorDeclarationParam, context);
    }
    public virtual TReturn VisitConstructorReference ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IConstructorReference constructorReferenceParam, TContext context) {
      return VisitElement (constructorReferenceParam, context);
    }
    public virtual TReturn VisitCreationExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ICreationExpression creationExpressionParam, TContext context) {
      return VisitElement (creationExpressionParam, context);
    }
    public virtual TReturn VisitCreationWithOverridingMethodsExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ICreationWithOverridingMethodsExpression creationWithOverridingMethodsExpressionParam, TContext context) {
      return VisitElement (creationWithOverridingMethodsExpressionParam, context);
    }
    public virtual TReturn VisitDisjunctionPattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IDisjunctionPattern disjunctionPatternParam, TContext context) {
      return VisitElement (disjunctionPatternParam, context);
    }
    public virtual TReturn VisitDoExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IDoExpression doExpressionParam, TContext context) {
      return VisitElement (doExpressionParam, context);
    }
    public virtual TReturn VisitDoExpressionDefinition ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IDoExpressionDefinition doExpressionDefinitionParam, TContext context) {
      return VisitElement (doExpressionDefinitionParam, context);
    }
    public virtual TReturn VisitDowncastExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IDowncastExpression downcastExpressionParam, TContext context) {
      return VisitElement (downcastExpressionParam, context);
    }
    public virtual TReturn VisitDowncastExpressionToType ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IDowncastExpressionToType downcastExpressionToTypeParam, TContext context) {
      return VisitElement (downcastExpressionToTypeParam, context);
    }
    public virtual TReturn VisitExceptionAlias ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IExceptionAlias exceptionAliasParam, TContext context) {
      return VisitElement (exceptionAliasParam, context);
    }
    public virtual TReturn VisitExceptionDeclaration ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IExceptionDeclaration exceptionDeclarationParam, TContext context) {
      return VisitElement (exceptionDeclarationParam, context);
    }
    public virtual TReturn VisitExceptionReference ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IExceptionReference exceptionReferenceParam, TContext context) {
      return VisitElement (exceptionReferenceParam, context);
    }
    public virtual TReturn VisitExpressionBlock ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IExpressionBlock expressionBlockParam, TContext context) {
      return VisitElement (expressionBlockParam, context);
    }
    public virtual TReturn VisitExpressionSequence ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IExpressionSequence expressionSequenceParam, TContext context) {
      return VisitElement (expressionSequenceParam, context);
    }
    public virtual TReturn VisitFieldAssignment ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IFieldAssignment fieldAssignmentParam, TContext context) {
      return VisitElement (fieldAssignmentParam, context);
    }
    public virtual TReturn VisitFieldAssignmentList ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentList fieldAssignmentListParam, TContext context) {
      return VisitElement (fieldAssignmentListParam, context);
    }
    public virtual TReturn VisitFieldDeclaration ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IFieldDeclaration fieldDeclarationParam, TContext context) {
      return VisitElement (fieldDeclarationParam, context);
    }
    public virtual TReturn VisitFieldDeclarationList ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IFieldDeclarationList fieldDeclarationListParam, TContext context) {
      return VisitElement (fieldDeclarationListParam, context);
    }
    public virtual TReturn VisitFieldPattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IFieldPattern fieldPatternParam, TContext context) {
      return VisitElement (fieldPatternParam, context);
    }
    public virtual TReturn VisitFieldPatternList ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IFieldPatternList fieldPatternListParam, TContext context) {
      return VisitElement (fieldPatternListParam, context);
    }
    public virtual TReturn VisitFieldReference ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IFieldReference fieldReferenceParam, TContext context) {
      return VisitElement (fieldReferenceParam, context);
    }
    public virtual TReturn VisitForAllTypeExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IForAllTypeExpression forAllTypeExpressionParam, TContext context) {
      return VisitElement (forAllTypeExpressionParam, context);
    }
    public virtual TReturn VisitForStatementExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IForStatementExpression forStatementExpressionParam, TContext context) {
      return VisitElement (forStatementExpressionParam, context);
    }
    public virtual TReturn VisitFunExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IFunExpression funExpressionParam, TContext context) {
      return VisitElement (funExpressionParam, context);
    }
    public virtual TReturn VisitFunctionExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IFunctionExpression functionExpressionParam, TContext context) {
      return VisitElement (functionExpressionParam, context);
    }
    public virtual TReturn VisitFunctionType ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IFunctionType functionTypeParam, TContext context) {
      return VisitElement (functionTypeParam, context);
    }
    public virtual TReturn VisitIdReference ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IIdReference idReferenceParam, TContext context) {
      return VisitElement (idReferenceParam, context);
    }
    public virtual TReturn VisitIfStatementExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IIfStatementExpression ifStatementExpressionParam, TContext context) {
      return VisitElement (ifStatementExpressionParam, context);
    }
    public virtual TReturn VisitImplementationUnit ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IImplementationUnit implementationUnitParam, TContext context) {
      return VisitElement (implementationUnitParam, context);
    }
    public virtual TReturn VisitInfixOperatorExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IInfixOperatorExpression infixOperatorExpressionParam, TContext context) {
      return VisitElement (infixOperatorExpressionParam, context);
    }
    public virtual TReturn VisitLazyExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ILazyExpression lazyExpressionParam, TContext context) {
      return VisitElement (lazyExpressionParam, context);
    }
    public virtual TReturn VisitLazyType ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ILazyType lazyTypeParam, TContext context) {
      return VisitElement (lazyTypeParam, context);
    }
    public virtual TReturn VisitLetDefinition ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ILetDefinition letDefinitionParam, TContext context) {
      return VisitElement (letDefinitionParam, context);
    }
    public virtual TReturn VisitListConcatenateExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IListConcatenateExpression listConcatenateExpressionParam, TContext context) {
      return VisitElement (listConcatenateExpressionParam, context);
    }
    public virtual TReturn VisitListConstructorExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IListConstructorExpression listConstructorExpressionParam, TContext context) {
      return VisitElement (listConstructorExpressionParam, context);
    }
    public virtual TReturn VisitListConstructorPattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IListConstructorPattern listConstructorPatternParam, TContext context) {
      return VisitElement (listConstructorPatternParam, context);
    }
    public virtual TReturn VisitLocalDeclarationsInExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ILocalDeclarationsInExpression localDeclarationsInExpressionParam, TContext context) {
      return VisitElement (localDeclarationsInExpressionParam, context);
    }
    public virtual TReturn VisitMatchClause ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IMatchClause matchClauseParam, TContext context) {
      return VisitElement (matchClauseParam, context);
    }
    public virtual TReturn VisitMatchExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IMatchExpression matchExpressionParam, TContext context) {
      return VisitElement (matchExpressionParam, context);
    }
    public virtual TReturn VisitMemberAccessExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IMemberAccessExpression memberAccessExpressionParam, TContext context) {
      return VisitElement (memberAccessExpressionParam, context);
    }
    public virtual TReturn VisitModuleReference ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReference moduleReferenceParam, TContext context) {
      return VisitElement (moduleReferenceParam, context);
    }
    public virtual TReturn VisitModuleReferenceList ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReferenceList moduleReferenceListParam, TContext context) {
      return VisitElement (moduleReferenceListParam, context);
    }
    public virtual TReturn VisitModuleReferenceOld ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReferenceOld moduleReferenceOldParam, TContext context) {
      return VisitElement (moduleReferenceOldParam, context);
    }
    public virtual TReturn VisitMultiParameterTypeReference ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IMultiParameterTypeReference multiParameterTypeReferenceParam, TContext context) {
      return VisitElement (multiParameterTypeReferenceParam, context);
    }
    public virtual TReturn VisitMultipleMatching ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IMultipleMatching multipleMatchingParam, TContext context) {
      return VisitElement (multipleMatchingParam, context);
    }
    public virtual TReturn VisitMutableBindingValue ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IMutableBindingValue mutableBindingValueParam, TContext context) {
      return VisitElement (mutableBindingValueParam, context);
    }
    public virtual TReturn VisitOneParameterTypeReference ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IOneParameterTypeReference oneParameterTypeReferenceParam, TContext context) {
      return VisitElement (oneParameterTypeReferenceParam, context);
    }
    public virtual TReturn VisitOpenModuleDefinition ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IOpenModuleDefinition openModuleDefinitionParam, TContext context) {
      return VisitElement (openModuleDefinitionParam, context);
    }
    public virtual TReturn VisitOrExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IOrExpression orExpressionParam, TContext context) {
      return VisitElement (orExpressionParam, context);
    }
    public virtual TReturn VisitParameterizedConstructorPattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IParameterizedConstructorPattern parameterizedConstructorPatternParam, TContext context) {
      return VisitElement (parameterizedConstructorPatternParam, context);
    }
    public virtual TReturn VisitParenthesizedExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IParenthesizedExpression parenthesizedExpressionParam, TContext context) {
      return VisitElement (parenthesizedExpressionParam, context);
    }
    public virtual TReturn VisitParenthesizedFieldValueExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IParenthesizedFieldValueExpression parenthesizedFieldValueExpressionParam, TContext context) {
      return VisitElement (parenthesizedFieldValueExpressionParam, context);
    }
    public virtual TReturn VisitParenthesizedPattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IParenthesizedPattern parenthesizedPatternParam, TContext context) {
      return VisitElement (parenthesizedPatternParam, context);
    }
    public virtual TReturn VisitParenthesizedType ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IParenthesizedType parenthesizedTypeParam, TContext context) {
      return VisitElement (parenthesizedTypeParam, context);
    }
    public virtual TReturn VisitPatternMatching ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IPatternMatching patternMatchingParam, TContext context) {
      return VisitElement (patternMatchingParam, context);
    }
    public virtual TReturn VisitPrefixOperatorExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IPrefixOperatorExpression prefixOperatorExpressionParam, TContext context) {
      return VisitElement (prefixOperatorExpressionParam, context);
    }
    public virtual TReturn VisitQualifiedIdReference ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IQualifiedIdReference qualifiedIdReferenceParam, TContext context) {
      return VisitElement (qualifiedIdReferenceParam, context);
    }
    public virtual TReturn VisitQualifiedIdentifierName ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IQualifiedIdentifierName qualifiedIdentifierNameParam, TContext context) {
      return VisitElement (qualifiedIdentifierNameParam, context);
    }
    public virtual TReturn VisitQualifiedValueName ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IQualifiedValueName qualifiedValueNameParam, TContext context) {
      return VisitElement (qualifiedValueNameParam, context);
    }
    public virtual TReturn VisitQualifiedValueReference ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IQualifiedValueReference qualifiedValueReferenceParam, TContext context) {
      return VisitElement (qualifiedValueReferenceParam, context);
    }
    public virtual TReturn VisitRangePattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IRangePattern rangePatternParam, TContext context) {
      return VisitElement (rangePatternParam, context);
    }
    public virtual TReturn VisitRecordExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IRecordExpression recordExpressionParam, TContext context) {
      return VisitElement (recordExpressionParam, context);
    }
    public virtual TReturn VisitRecordPattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IRecordPattern recordPatternParam, TContext context) {
      return VisitElement (recordPatternParam, context);
    }
    public virtual TReturn VisitRecordTypeRepresentation ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IRecordTypeRepresentation recordTypeRepresentationParam, TContext context) {
      return VisitElement (recordTypeRepresentationParam, context);
    }
    public virtual TReturn VisitStringConcatenateExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IStringConcatenateExpression stringConcatenateExpressionParam, TContext context) {
      return VisitElement (stringConcatenateExpressionParam, context);
    }
    public virtual TReturn VisitTryFinallyExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITryFinallyExpression tryFinallyExpressionParam, TContext context) {
      return VisitElement (tryFinallyExpressionParam, context);
    }
    public virtual TReturn VisitTryWithExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITryWithExpression tryWithExpressionParam, TContext context) {
      return VisitElement (tryWithExpressionParam, context);
    }
    public virtual TReturn VisitTupleExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITupleExpression tupleExpressionParam, TContext context) {
      return VisitElement (tupleExpressionParam, context);
    }
    public virtual TReturn VisitTuplePattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITuplePattern tuplePatternParam, TContext context) {
      return VisitElement (tuplePatternParam, context);
    }
    public virtual TReturn VisitTupleType ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITupleType tupleTypeParam, TContext context) {
      return VisitElement (tupleTypeParam, context);
    }
    public virtual TReturn VisitTypeDeclaration ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration typeDeclarationParam, TContext context) {
      return VisitElement (typeDeclarationParam, context);
    }
    public virtual TReturn VisitTypeDefinition ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDefinition typeDefinitionParam, TContext context) {
      return VisitElement (typeDefinitionParam, context);
    }
    public virtual TReturn VisitTypeParameterDeclaration ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITypeParameterDeclaration typeParameterDeclarationParam, TContext context) {
      return VisitElement (typeParameterDeclarationParam, context);
    }
    public virtual TReturn VisitTypeParameterList ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITypeParameterList typeParameterListParam, TContext context) {
      return VisitElement (typeParameterListParam, context);
    }
    public virtual TReturn VisitTypeParameterReference ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITypeParameterReference typeParameterReferenceParam, TContext context) {
      return VisitElement (typeParameterReferenceParam, context);
    }
    public virtual TReturn VisitTypeRefOrConstructorDecl ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITypeRefOrConstructorDecl typeRefOrConstructorDeclParam, TContext context) {
      return VisitElement (typeRefOrConstructorDeclParam, context);
    }
    public virtual TReturn VisitTypeReference ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITypeReference typeReferenceParam, TContext context) {
      return VisitElement (typeReferenceParam, context);
    }
    public virtual TReturn VisitTypeTestExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITypeTestExpression typeTestExpressionParam, TContext context) {
      return VisitElement (typeTestExpressionParam, context);
    }
    public virtual TReturn VisitTypeTestPattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITypeTestPattern typeTestPatternParam, TContext context) {
      return VisitElement (typeTestPatternParam, context);
    }
    public virtual TReturn VisitTypedExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITypedExpression typedExpressionParam, TContext context) {
      return VisitElement (typedExpressionParam, context);
    }
    public virtual TReturn VisitTypedPattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITypedPattern typedPatternParam, TContext context) {
      return VisitElement (typedPatternParam, context);
    }
    public virtual TReturn VisitUnaryMinusExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IUnaryMinusExpression unaryMinusExpressionParam, TContext context) {
      return VisitElement (unaryMinusExpressionParam, context);
    }
    public virtual TReturn VisitUnderlinePattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IUnderlinePattern underlinePatternParam, TContext context) {
      return VisitElement (underlinePatternParam, context);
    }
    public virtual TReturn VisitUnderlineType ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IUnderlineType underlineTypeParam, TContext context) {
      return VisitElement (underlineTypeParam, context);
    }
    public virtual TReturn VisitUpcastExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IUpcastExpression upcastExpressionParam, TContext context) {
      return VisitElement (upcastExpressionParam, context);
    }
    public virtual TReturn VisitUpcastExpressionToType ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IUpcastExpressionToType upcastExpressionToTypeParam, TContext context) {
      return VisitElement (upcastExpressionToTypeParam, context);
    }
    public virtual TReturn VisitValueDeclarationPattern ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IValueDeclarationPattern valueDeclarationPatternParam, TContext context) {
      return VisitElement (valueDeclarationPatternParam, context);
    }
    public virtual TReturn VisitValueReferenceExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpression valueReferenceExpressionParam, TContext context) {
      return VisitElement (valueReferenceExpressionParam, context);
    }
    public virtual TReturn VisitValueSpecification ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IValueSpecification valueSpecificationParam, TContext context) {
      return VisitElement (valueSpecificationParam, context);
    }
    public virtual TReturn VisitWhileStatementExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IWhileStatementExpression whileStatementExpressionParam, TContext context) {
      return VisitElement (whileStatementExpressionParam, context);
    }
    public virtual TReturn VisitWithRecordExpression ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IWithRecordExpression withRecordExpressionParam, TContext context) {
      return VisitElement (withRecordExpressionParam, context);
    }
    public virtual TReturn VisitWithoutParameterTypeReference ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IWithoutParameterTypeReference withoutParameterTypeReferenceParam, TContext context) {
      return VisitElement (withoutParameterTypeReferenceParam, context);
    }
  }
}