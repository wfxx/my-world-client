namespace Const.Login
{
    // 登录状态
    public enum LoginStatus
    {
        // 是否需要更新，先检查强制更新，再检测热更新
        CheckUpdate,
        // 热更新中
        Download,
        // 登录/注册
        CheckAccount,
        // 选择角色/编辑形象
        CheckRole,
        // 错误提示中
        InError,
    }

    public enum LoginWidgetType
    {
        // 热更新中
        Download,
        // 登录/注册
        Login,
        // 选择角色/编辑形象
        Start
    }
}