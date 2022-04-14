-- 1. 甲供、乙供材料库存数量
SELECT wuliao.ID, -- 物料编号
 renwuliao.renwuid, 
 renwuliao.kucun as shu, -- 数量
 wuliao.mingzi, -- 物料名称
 wuliao.guige, -- 规格
 wuliao.danwei, -- 单位
 renwuliao.wuliaoid,
renwu.mingzi as mingzi2  -- 项目名称
    FROM 
        (renwu INNER JOIN renwuliao ON renwu.ID = renwuliao.renwuid) 
        INNER JOIN wuliao ON renwuliao.wuliaoid = wuliao.ID 
        where renwuliao.yiling+renwuliao.yiling2>0 and renwuliao.status=0;
       
-- 甲供材料
SELECT renwuliao.renwuid,
 renwuliao.shuliang, --数量 ？
 renwuliao.yiling, -- 已领
 renwuliao.shuliang-renwuliao.yiling as weiling, -- 未领
 wuliao.mingzi, -- 物料名称
 wuliao.guige, -- 规格
 wuliao.danwei, -- 单位
 renwuliao.wuliaoid -- 物料编号
 FROM wuliao 
    INNER JOIN renwuliao ON wuliao.ID = renwuliao.wuliaoid 
    where renwuliao.renwuid={0} and renwuliao.shuliang>0;
    
-- 乙供材料
SELECT renwuliao.renwuid,
 renwuliao.shuliang2, -- 数量
 renwuliao.yiling2, -- 已领
 renwuliao.shuliang2-renwuliao.yiling2 as weiling2, -- 未领
 wuliao.mingzi,
 wuliao.guige,
 wuliao.danwei,
 renwuliao.wuliaoid 
 FROM wuliao 
 INNER JOIN renwuliao 
 ON wuliao.ID = renwuliao.wuliaoid 
 where renwuliao.renwuid={0} and renwuliao.shuliang2>0