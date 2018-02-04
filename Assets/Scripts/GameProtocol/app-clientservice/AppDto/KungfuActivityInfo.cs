
//  G e n e r a t e d   f i l e .   D o   n o t   e d i t . 
// Generated By Gecko,if you need to edit it,extends it! 

//using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AppDto
{  
  /** 武术大会活动信息 */
  public class KungfuActivityInfo : GeneralResponse
  {

	public enum KungfuStateEnum
	{
    	/** 未开始 */
    	Normal = 0,
    	/** 准备阶段 */
    	Ready = 1,
    	/** 比赛阶段 */
    	Racing = 2,
    	/** 结束清除阶段 */
    	End = 3,
	}


    /** 当前阶段结束时间 */
    public long endAt;
    
    /** 当前状态 */
    public int state;
    

  }
}
