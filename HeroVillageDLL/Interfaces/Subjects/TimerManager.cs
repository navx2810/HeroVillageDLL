using System.Collections.Generic;

namespace HeroVillageDLL
{
	public class TimerManager : BISubject<Timer>
	{
		List<Timer> timers;
		public TimerManager ()
		{
			timers = new List<Timer> ();
		}

		public void attach (Timer observer)
		{
			timers.Add (observer);
		}

		public void dettach (Timer observer)
		{
			timers.Remove (observer);
		}

		public void notify ()
		{
			foreach (Timer timer in timers)
				timer.update (this, EventState.TIMER_UPDATE);
		}
	}
}

