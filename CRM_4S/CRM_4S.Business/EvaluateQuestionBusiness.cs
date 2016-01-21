using CRM_4S.Business.Service;
using CRM_4S.DataService.Model;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class EvaluateQuestionBusiness : BusinessBase<EvaluateQuestionBusiness>
    {
        public IList<EvaluateQuestionInfo> GetEvaluateQuestions()
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetEvaluateQuestions";

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetEvaluateQuestions.uspGetEvaluateQuestions", true);

            return DoFunctionWithLog<List<EvaluateQuestionInfo>>(() =>
            {
                return ConvertToList<EvaluateQuestionInfo>(result);

            }, null, "GetEvaluateQuestions.ConvertToList", true);
        }

        public void AddEvaluateQuestion(EvaluateQuestionInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspAddEvaluateQuestion";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "AddEvaluateQuestion.uspAddEvaluateQuestion", true);
        }

        public void UpdateEvaluateQuestion(EvaluateQuestionInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspUpdateEvaluateQuestion";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "UpdateEvaluateQuestion.uspUpdateEvaluateQuestion", true);
        }

        public void DeleteEvaluateQuestion(EvaluateQuestionInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspDeleteEvaluateQuestion";
                functionParms.Pams = new Dictionary<string, object>();
                functionParms.Pams.Add("EvaluateQuestionId", info.Id);

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "DeleteEvaluateQuestion.uspDeleteEvaluateQuestion", true);

        }
    }
}
