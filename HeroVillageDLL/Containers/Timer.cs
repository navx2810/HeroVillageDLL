using System;

namespace HeroVillageDLL
{
	public class Timer : BIObserver<TimerManager>
	{
		private static TimeSpan ONE_SECOND_TICK = new TimeSpan (0, 0, 1);

		public DateTime startTime { get; private set; }
		public DateTime endTime { get; private set; }
		public TimeSpan timeToCompletion { get; private set; }
		public TimeSpan currentTimeLeft { get; private set; }


		public Timer (TimeSpan timeToCompletion)
		{
			this.timeToCompletion = timeToCompletion;
			startTime = DateTime.UtcNow;
			endTime = startTime + timeToCompletion;
			currentTimeLeft = timeToCompletion;
		}

		public void update (TimerManager subject, EventState state)
		{
			currentTimeLeft -= ONE_SECOND_TICK;
		}

		public string getCurrentTimeLeft ()
		{
			return String.Format ("{0}:{1}:{2}", currentTimeLeft.Hours, currentTimeLeft.Minutes, currentTimeLeft.Seconds);
		}
	}
}

