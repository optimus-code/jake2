using Q2Sharp.Render;
using Q2Sharp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q2Sharp.Client
{
    public class entity_t : ICloneable
    {
        public model_t model;
        public float[] angles = new float[]{0, 0, 0};
        public float[] origin = new float[]{0, 0, 0};
        public int frame;
        public float[] oldorigin = new float[]{0, 0, 0};
        public int oldframe;
        public float backlerp;
        public int skinnum;
        public int lightstyle;
        public float alpha;
        public image_t skin;
        public int flags;
        public virtual void Set(entity_t src)
        {
            this.model = src.model;
            Math3D.VectorCopy(src.angles, this.angles);
            Math3D.VectorCopy(src.origin, this.origin);
            this.frame = src.frame;
            Math3D.VectorCopy(src.oldorigin, this.oldorigin);
            this.oldframe = src.oldframe;
            this.backlerp = src.backlerp;
            this.skinnum = src.skinnum;
            this.lightstyle = src.lightstyle;
            this.alpha = src.alpha;
            this.skin = src.skin;
            this.flags = src.flags;
        }

        public virtual void Clear()
        {
            model = null;
            Math3D.VectorClear(angles);
            Math3D.VectorClear(origin);
            frame = 0;
            Math3D.VectorClear(oldorigin);
            oldframe = 0;
            backlerp = 0;
            skinnum = 0;
            lightstyle = 0;
            alpha = 0;
            skin = null;
            flags = 0;
        }

		public Object Clone( )
		{
            var newItem = new entity_t();
            newItem.Set( this );
            return newItem;
		}
	}
}