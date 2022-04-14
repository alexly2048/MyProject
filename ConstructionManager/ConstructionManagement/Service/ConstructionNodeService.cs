using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ConstructionManagement.Model;
using Dapper;
namespace ConstructionManagement.Service
{
    public class ConstructionNodeService:Connection
    {
        public ConstructionNodeService():base()
        {

        }        
        /// <summary>
        /// 查询所有施工节点数据
        /// </summary>
        /// <returns></returns>
        public IList<ConstructionNode> GetConstructionNodes()
        {
            try
            {
                string select = "SELECT ID,ConstructionNo,Name,ConstructionStart,CivilConstruction,ElectricStart,ElectronicTransfer,PowerCut,PowerCut2,PowerCut3,InOperation,BeCompleted,CloseAnAccount,SendKnot,Archive  FROM ConstructionNode";
                var result = Query<ConstructionNode>(select);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        ConstructionFileService fileService = new ConstructionFileService();
        ConstructionPlanService planService = new ConstructionPlanService();
        ConstructionQuantityService constructionQuantityService = new ConstructionQuantityService();
        ConstructionLogService constructionLogService = new ConstructionLogService();
        public bool DelConstructionNode(ConstructionNode node)
        {
            try
            {
                
                fileService.DeleteAppendixFileByParentId(node.ID); // 删除施工节点附件文件                
                constructionQuantityService.DelQuantityByParentId(node.ID); // 删除施工工程量相关数据
                planService.DeletePlanByParentId(node.ID); // 删除施工计划
                constructionLogService.DeleteConstructionLogByCode(node.ConstructionNo);

                string del = "DELETE FROM ConstructionNode WHERE ID = @ID";
                Execute(del, new { ID = node.ID });
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// 增加施工节点数据
        /// </summary>
        /// <param name="node"></param>
        public void AddNode(ConstructionNode node)
        {
            try
            {
                string insert = "INSERT INTO ConstructionNode (ConstructionNo,Name,ConstructionStart,CivilConstruction,ElectricStart,ElectronicTransfer,PowerCut,PowerCut2,PowerCut3,InOperation,BeCompleted,CloseAnAccount,SendKnot,Archive) VALUES (@ConstructionNo,@Name,@ConstructionStart,@CivilConstruction,@ElectricStart,@ElectronicTransfer,@PowerCut,@PowerCut2,@PowerCut3,@InOperation,@BeCompleted,@CloseAnAccount,@SendKnot,@Archive)";
                var result = Execute(insert, node);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 更新施工节点数据
        /// </summary>
        /// <param name="node"></param>
        public void UpdateNode(ConstructionNode node)
        {
            try
            {
                string update = "UPDATE ConstructionNode SET ConstructionNo=@ConstructionNo,Name = @Name, ConstructionStart = @ConstructionStart,CivilConstruction = @CivilConstruction,ElectricStart = @ElectricStart,ElectronicTransfer = @ElectronicTransfer,PowerCut = @PowerCut,PowerCut2 = @PowerCut2,PowerCut3 = @PowerCut3,InOperation = @InOperation,BeCompleted = @BeCompleted,CloseAnAccount = @CloseAnAccount,SendKnot = @SendKnot,Archive = @Archive WHERE ID=@ID";
                Execute(update, node);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
