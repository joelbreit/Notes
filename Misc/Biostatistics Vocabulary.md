# Biostatistics Vocabulary

## Mine

1. **Descriptive statistics** - numbers used to summarize data
2. **Inferential statistics** - numbers used to interpret a large body of data by examining only a small part of it
3. **Statistics** - numbers used to summarize the nature of information 
4. **Biostatistics** - analysis of data from the biological sciences and medicine 
5. **Qualitative variable** - variable that is described by categorizing rather than measuring with numbers (e.g. race)
6. **Discrete variable** - variable with gaps or interruptions in the values that it can have (e.g. number of daily admissions to a hospital (only whole numbers))
7. **Stratified Random Sampling** - dividing a group into groups that are similar within each other and sampling each group
8. **Statistic** - descriptive measure computed from the data of a sample
9. **Parameter** - descriptive measure computed from the data of a population
10. **Skewness** - the degree and direction of asymmetry in a distribution of values
11. **Positive skew** - longer tail to the right
12. **Negative skew** - longer tail to the left
13. **Variance (of data)** - the amount of dispersion present in a set of data 
14. **Variance (of a value)** - absolute measure of dispersion that uses squared units
15. **Formula for variance (estimate) of a sample** - result = sum((value - sample.mean) ** 2) for value in sample / (len(sample) - 1)
16. **Formula for variance of a population** - result = sum((value - sample.mean) ** 2) for value in sample / len(sample)
17. **Standard deviation** - absolute measure of dispersion that uses the original units
18. **Formula for standard deviation (estimate) of a sample** - result = sqrt(sum((value - sample.mean) ** 2) for value in sample) / (len(sample) - 1)
19. **Formula for standard deviation of a population** - result = sqrt(sum((value - sample.mean) ** 2) for value in sample) / len(sample)
20. **Coefficient of variation** - relative measure of dispersion
21. **Formula for coefficient of variation** - (population.std_dev / len(population)) * 100%
22. **Interquartile Range (IQR)** - range between the 3rd and 1st quartiles (75th percentile and the 25th percentile)
23. **Kurtosis** - measure of the degree to which a distribution is “peaked” or flat in comparison to a normal distribution whose graph is characterized by a bell-shaped appearance
24. **Mesokurtic** - a normal, or bell-shaped distribution (kurtosis = 0)
25. **Platykurtic** - a distribution with excessive proportion of observations in its tails (kurtosis < 0)
26. **Leptokurtic** - a distribution with a smaller proportion of observations in its tails (kurtosis > 0)
27. **Combination** - sequence of events with specified odds in which the order does not matter
28. **Permutation** - sequence of events with specified odds in which the order does matter
29. **Gaussian distribution** - the normal distribution
30. **Standard normal distribution / unit normal distribution** - normal distribution with the mean at 0 and a standard deviation of 1
31. **Distribution of sample mean for population with replacement** - 
32. **The Central Limit Theorem** - given a population of any non-normal functional form with a mean μ and finite variance 𝜎^2, the sampling distribution of x̄, computed from samples of size n from this population, will have mean μ and variance 𝜎^2/n and will be approximately normally distributed when the sample size is large

## Generated, Reviewed

1. **Sum of Squares** - Measure of the total variability in a dataset; sum((value** - mean for value in dataset) ** 2)
2. **t-statistic** - A standard statistic that indicates how many standard errors an observation is from the mean; used to assess the null hypothesis; good for some sample sizes; (sample.mean - hypothetical_mean) / standard_error
3. **F-test** - A test that calculates the ratio of variance between groups over the variance within groups; used to assess the significance of the differences between groups; between-group variability / within-group variability
4. **r (correlation coefficient)** - A measure that describes the size and direction of a relationship between two variables; ranges from -1 to 1, where -1 shows a perfect negative correlation, 1 shows a perfect positive correlation, and 0 shows no correlation
5. **Signal** - The true information or underlying pattern in your data; the component of data that you're interested in, as opposed to the "noise"
6. **Noise** - The random variability that is in your data that can't be explained by your model; the part of the data that you are not interested in, as it distracts from the "signal"
7. **Alpha Value** - The threshold for statistical significance; the probability of incorrectly rejecting the null hypothesis commonly set at 0.05, indicating a 5% risk of a false positive
8. **Beta Value** - The probability of incorrectly accepting the null hypothesis
9. **Type 1 Error** - A type of error that occurs when a true null hypothesis is rejected (false positive)
10. **Type 2 Error** - A type of error that occurs when a false null hypothesis is not rejected (false negative)
11. **Correlation** - A statistical measure that describes the degree to which two variables move in relation to each other. It is standardized, making it not scale-dependent, and ranges from -1 to 1
12. **ANOVA (Analysis of Variance)** - A statistical test used to analyze the differences among 3 or more group means in a sample by comparing the amount of variation within each group to the amount of variation between groups
13. **MANOVA (Multivariate Analysis of Variance)** - A statistical test used when there is more than 1 dependent variable to analyze whether changes in the independent variable(s) have significant effects on the dependent variables
14. **ANCOVA (Analysis of Covariance)** - A statistical method that evaluates whether population means of a dependent variable differ significantly among groups, adjusting for one or more covariates that might influence the response
15. **Cronbach's Alpha** - A measure of internal consistency, that is, how closely related a set of items are as a group. It is considered a measure of scale reliability and usually used in social sciences
16. **Student's t-test** - A statistical test that compares the means of two groups to determine if they are significantly different from each other. It assumes that the data follows a normal distribution and that variances are equal
17. **Paired t-test** - A type of t-test that is used to compare the means of the same group or item under two separate scenarios. It's often used to test the statistical difference of two time points in a before-after study design
18. **Parametric** - Refers to statistical tests, models, or procedures that involve assumptions about the shape of your data distribution or the relationship between variables. These tests often assume normal distribution and include methods like t-tests and ANOVAs
19. **Nonparametric** - Refers to statistical methods that do not assume a specific distribution to the data. These tests are often used when the data may not meet the assumptions of parametric methods, such as data that is not normally distributed. Examples include the Mann-Whitney U test and the Wilcoxon signed-rank test
20. **Chi-Squared Test** - A statistical test that is used to determine whether there is a significant association between two categorical variables in a sample. The test compares the observed frequencies in each category of a contingency table with the frequencies expected under the null hypothesis of no association
21. **Chi-Squared Distribution** - The distribution of a sum of the squares of k independent standard normal random variables. It is a special case of the gamma distribution and is one of the most widely used probability distributions in inferential statistics
22. **Mann-Whitney U-Test** - A nonparametric statistical significance test for determining whether two independent samples were drawn from a population with the same distribution often used as an alternative to the independent sample t-test when the normality assumption is in doubt
23. **Wilcoxon Rank-Sum Test** - A non-parametric alternative to the two-sample t-test which is based not on the raw data but on the ranks of the data used when the assumptions of the t-test are not met
24. **Kruskal-Wallis One-Way ANOVA by Ranks** - A non-parametric method for testing whether samples originate from the same distribution used for comparing two or more independent samples of equal or different sample sizes, serving as a non-parametric alternative to the one-way ANOVA
25. **Bonferroni Correction** - A method used to counteract the problem of multiple comparisons. It sets the significance cut-off level (alpha) for the entire set of comparisons at the alpha level divided by the number of comparisons being made
26. **Friedman Test** - A non-parametric statistical test similar to the parametric repeated measures ANOVA used to detect differences in treatments across multiple test attempts which involves ranking each row then considering the values of ranks by columns
27. **Holm Correction** - A variation of the Bonferroni correction method used to control the family-wise error rate in multiple hypothesis testing that provides a balance between power and type I error control
28. **Funnel Plot** - A simple scatter plot used in meta-analysis to visualize the relationship between estimates of effect size from individual studies and the precision of those estimates used to detect publication bias where the effects observed in smaller studies show greater treatment effect than larger studies
29. **Z-test** - A statistical test used to determine whether two population means are different when the variances are known, the sample size is large, and a normal distribution is assumed
30. **F-Test** - A statistical test used to compare the variances of two populations used in ANOVA to test the hypothesis that the means of several populations are equal

## Generated, Need To Review

1. **Cohen’s d** - A measure of effect size that assesses the difference between two means in terms of standard deviation, not standard error. A larger value indicates a greater degree of separation between the means
2. **Two-Tailed z-alpha** - In a two-tailed test, you're testing for the possibility of the relationship in both directions. The alpha level (significance level) is divided by two, to allocate a portion to both ends of the distribution. For instance, with an alpha level of 0.05, each tail would receive 0.025
3. **Q and I^2 statistics** - Used in meta-analysis, the Q statistic tests the null hypothesis that all studies in the analysis share a common effect size. I^2 statistic describes the percentage of variation across studies that is due to heterogeneity rather than chance
4. **Hedge’s Standardized Effect Size (ES)** - An estimate of effect size used for studies where the standard deviation of the population is not known, but is estimated from the data. Hedges' g is a variation of Cohen’s d that corrects for bias due to small sample sizes
5. **Egger’s Regression Test** - A statistical test used in meta-analysis that tests for funnel plot asymmetry, which is a possible indication of publication bias. The null hypothesis is that the intercept of the regression line is equal to zero, indicating no bias
6. **tau^2 (Tau-squared)** - In meta-analysis, tau-squared is an estimate of the between-study variance in a random-effects model. It quantifies the heterogeneity of the effect sizes of the included studies
7. **Cohen’s Kappa Statistic (κ)** - A statistic that measures inter-rater agreement for qualitative (categorical) items. It is generally thought to be a more robust measure than simple percent agreement calculation, as it considers the agreement occurring by chance
8. **Cochrane Risk of Bias Instrument** - A tool used in systematic reviews to assess the risk of bias in the design, conduct, and analysis of randomized controlled trials. It examines several domains such as random sequence generation, blinding of participants and personnel, and selective reporting
9. **Inverse Heterogeneity (IVhet) Model** - A method used in meta-analysis which aims to provide a more accurate estimate of the global average treatment effect. The IVhet model does not require a common effect size for all studies
10. **Fixed Effects Model** - In meta-analysis, a fixed effects model assumes that the true effect size is the same in all studies. The estimate of the overall effect size is therefore a weighted average of the effect sizes of the individual studies
11. **Random Effects Model** - In meta-analysis, a random effects model assumes that the true effect size varies from study to study. The model considers both within-study variance and between-study variance in calculating the overall effect size and its confidence interval
12. **Delta R Square** - The change in the coefficient of determination (R-square) when a predictor is added to or removed from a regression model. It provides a measure of the contribution of that predictor to the model
13. **Power** - In hypothesis testing, power is the probability that a test correctly rejects a false null hypothesis (i.e., it is the probability of not committing a Type II error). The power of a test is affected by sample size, variability, level of significance, and effect size
14. **Adjusted Odds Ratio** - A measure of association that quantifies the relationship between an exposure and an outcome, controlling for or adjusting for other variables in multivariable logistic regression models
15. **Unadjusted Odds Ratio** - A measure of association that quantifies the relationship between an exposure and an outcome without controlling for or adjusting for other variables.
16. **Nagelkerke Pseudo R-Square Measure** - A version of the coefficient of determination (R-square) used with logistic regression. It provides a measure of the proportion of variance in the dependent variable explained by the model, on a 0 to 1 scale
17. **Lowess line** - A tool used in regression analysis that creates a smooth line through a scatterplot to help visualize the relationship between variables. It stands for Locally Weighted Scatterplot Smoothing
18. **R-Square vs Adjusted R-Square** - R-Square is a statistical measure of how close the data are to the fitted regression line, while Adjusted R-Square accounts for the number of predictors in the model. It adjusts the statistic based on the number of terms in the model
19. **Standardized Beta** - In regression analysis, standardized beta coefficients are the coefficients obtained when the independent variables are standardized so that their variances are 1. They allow for direct comparison between variables in the model
20. **OLS Regression** - Ordinary Least Squares (OLS) Regression is a statistical method used to estimate the relationships among variables. It minimizes the sum of the squares in the difference between the observed and predicted values of the dependent variable configured as a straight line
21. **Assumptions of Linear Regression** - The key assumptions of linear regression are: linearity (the relationship between the variables is linear), independence (the observations are independent of each other), homoscedasticity (the variance of the residuals is constant across all levels of the independent variables), and normality (the residuals are normally distributed)
22. **Proportional Odds Assumption** - In ordinal logistic regression, the proportional odds assumption (also called parallel lines assumption) suggests that the relationship between the outcome and each predictor variable is constant across all levels of the outcome
23. **MAE/ MSE/ RMSE** - Mean Absolute Error (MAE), Mean Squared Error (MSE), and Root Mean Squared Error (RMSE) are all loss functions used to evaluate the performance of a prediction model. MAE is the simplest, as it's the average error magnitude. MSE and RMSE give more weight to larger errors
24. **Odds Ratio** - A measure of association between an exposure and an outcome. It represents the odds that an outcome will occur given a particular exposure, compared to the odds of the outcome occurring in the absence of that exposure
25. **Risk Ratio** - A comparison of the risk of a given event happening in an exposed group versus a non-exposed group. It is computed as the ratio of the probabilities of the event in the two groups
26. **Longitudinal Methods** - Statistical methods used for analyzing data collected over time. These methods take into account the correlation between repeated measurements on the same subject. Examples include repeated measures ANOVA, mixed models, and growth curve analysis
27. **Factor Analysis** - A statistical method used to describe variability among observed, correlated variables in terms of a potentially lower number of unobserved variables called factors. It is often used in data reduction to identify a small number of factors that explain most of the variance observed in a much larger number of manifest variables
28. **Path Analysis** - A subset of structural equation modeling, path analysis is used to describe the directed dependencies among a set of variables. It allows for multivariate statistical analysis of several regression relationships simultaneously
29. **Structural Equation Modeling** - A multivariate statistical analysis technique used to analyze structural relationships. This technique is the combination of factor analysis and multiple regression analysis, and it is used to analyze the structural relationship between measured variables and latent constructs
30. **Power Analysis** - A method for finding the statistical power of a test, i.e., the probability of rejecting the null hypothesis when it is false. Power analysis can also be used to calculate the minimum sample size required so that one can reasonably detect an effect of a given size
31. **Pearson Correlation Coefficient** - A measure of the linear correlation between two variables X and Y. It has a value between +1 and −1, where 1 is total positive linear correlation, 0 is no linear correlation, and −1 is total negative linear correlation
32. **Sum of Squares of Residuals** - The sum of the squares of residuals (deviations predicted from actual empirical values of data). It is a measure of the discrepancy between the data and an estimation model, often used in regression analysis to find the best fit line
33. **Multivariate Analysis of Variance (MANOVA)** - An extension of the one-way analysis of variance (ANOVA) that covers cases where there are more than one dependent variable. MANOVA tests whether changes in the independent variables have significant effects on the dependent variables
34. **Analysis of Covariance (ANCOVA)** - A general linear model which blends ANOVA and regression. ANCOVA evaluates whether the means of a dependent variable are equal across levels of a categorical independent variable, while statistically controlling for the effects of other continuous variables that are not of primary interest, known as covariates