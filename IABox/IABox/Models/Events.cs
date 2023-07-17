using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Events
    {
        public Events()
        {
            EventCheckMulta = new HashSet<EventCheckMulta>();
            EventFoto = new HashSet<EventFoto>();
            EventPersonnel = new HashSet<EventPersonnel>();
            EventsPatente = new HashSet<EventsPatente>();
            NotificationsMsg = new HashSet<NotificationsMsg>();
        }

        public long Id { get; set; }
        public int TrackId { get; set; }
        public DateTime DateEventIni { get; set; }
        public DateTime? DateEventEnd { get; set; }
        public int Prediction { get; set; }
        public double Probability { get; set; }
        public byte[] Thumbnail { get; set; }
        public long IdCamera { get; set; }
        public int? IdImage { get; set; }
        public long IdEventType { get; set; }

        public virtual Cameras IdCameraNavigation { get; set; }
        public virtual EventType IdEventTypeNavigation { get; set; }
        public virtual Images IdImageNavigation { get; set; }
        public virtual ICollection<EventCheckMulta> EventCheckMulta { get; set; }
        public virtual ICollection<EventFoto> EventFoto { get; set; }
        public virtual ICollection<EventPersonnel> EventPersonnel { get; set; }
        public virtual ICollection<EventsPatente> EventsPatente { get; set; }
        public virtual ICollection<NotificationsMsg> NotificationsMsg { get; set; }
    }
}
