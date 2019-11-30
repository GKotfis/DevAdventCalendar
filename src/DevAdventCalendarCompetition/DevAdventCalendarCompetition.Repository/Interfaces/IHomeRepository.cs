﻿using System;
using System.Collections.Generic;
using DevAdventCalendarCompetition.Repository.Models;

namespace DevAdventCalendarCompetition.Repository.Interfaces
{
    public interface IHomeRepository
    {
        Test GetCurrentTest();

        Test GetTestByNumber(int testNumber);

        TestAnswer GetTestAnswerByUserId(string userId, int testId);

        List<Test> GetAllTests();

        List<Test> GetTestsWithUserAnswers();

        int GetCorrectAnswersCountForUser(string userId);

        int GetCorrectAnswersCountForUserAndDateRange(string userId, DateTimeOffset dateFrom, DateTimeOffset dateTo);

        int GetWrongAnswersCountForUserAndDateRange(string userId, DateTimeOffset dateFrom, DateTimeOffset dateTo);

        List<Result> GetAllTestResults();

        int GetUserPosition(string userId);

        List<Result> GetTestResultsForWeek(int weekNumber);
    }
}