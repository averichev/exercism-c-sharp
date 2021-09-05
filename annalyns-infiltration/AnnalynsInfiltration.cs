using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return knightIsAwake == false;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (!knightIsAwake && archerIsAwake && !prisonerIsAwake)
        {
            return true;
        }

        if (knightIsAwake && !archerIsAwake && !prisonerIsAwake)
        {
            return true;
        }

        if (!knightIsAwake && !archerIsAwake && prisonerIsAwake)
        {
            return true;
        }

        if (knightIsAwake && !archerIsAwake)
        {
            return true;
        }

        if (!knightIsAwake && archerIsAwake)
        {
            return true;
        }
        if (knightIsAwake && !prisonerIsAwake)
        {
            return true;
        }

        return knightIsAwake;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return !archerIsAwake && prisonerIsAwake;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake,
        bool petDogIsPresent)
    {
        var allSleep = !knightIsAwake && !archerIsAwake && !prisonerIsAwake;
        if (allSleep) return petDogIsPresent;

        var onlyArcherWork = knightIsAwake && !archerIsAwake;
        if (petDogIsPresent && onlyArcherWork)
        {
            return true;
        }

        return !knightIsAwake && !archerIsAwake;
    }
}