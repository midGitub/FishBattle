
//  G e n e r a t e d   f i l e .   D o   n o t   e d i t . 
// Generated By Gecko,if you need to edit it,extends it! 

//using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AppDto
{  
  /** 武术大会信息 */
  public class KungfuInfoDto : GeneralResponse
  {

	public enum GiftState
	{
    	Unknow = 0,
    	/** 不可领取 */
    	UnAble = 1,
    	/** 可领取 */
    	Able = 2,
    	/** 已领取 */
    	Received = 3,
	}
	public enum MatchState
	{
    	Unknow = 0,
    	/** 活动准备阶段 */
    	MatchState_1 = 1,
    	/** 等待加入匹配列表 */
    	MatchState_2 = 2,
    	/** 等待匹配中 */
    	MatchState_3 = 3,
    	/** 暂离队员 */
    	MatchState_4 = 4,
    	/** 仅剩一只队伍 */
    	MatchState_5 = 5,
	}


    /** 排行榜 */
    public RankInfoDto rankInfoDto;
    
    /** 首战礼包状态 */
    public int joinBattleGiftState;
    
    /** 首胜礼包状态 */
    public int battleWinGiftState;
    
    /** 匹配进度 */
    public int matchState;
    

  }
}
