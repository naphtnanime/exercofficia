long timestamp = timelineSchedule.GetScheduleUpdateTimestamp();
if (timestamp > 0) {
    //  schedule needs to be updated
    UpdateSchedule();
} else {
    //  schedule is up to date
}
