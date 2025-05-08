class Lasagna
{
    private const int EXPECTED_MINUTES_IN_OVEN = 40;
    private const int MINUTES_PER_LAYER = 2;

    public int ExpectedMinutesInOven() => EXPECTED_MINUTES_IN_OVEN;

    public int RemainingMinutesInOven(int actualMinutes) => ExpectedMinutesInOven() - actualMinutes;

    public int PreparationTimeInMinutes(int layers) => MINUTES_PER_LAYER * layers;

    public int ElapsedTimeInMinutes(int layers, int actualMinutes) => PreparationTimeInMinutes(layers) + actualMinutes;
}
