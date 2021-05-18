namespace Inventory {
    export interface ScriptUserDefinition {
        Username?: string;
        DisplayName?: string;
        IsAdmin?: boolean;
        UserType?: number;
        Permissions?: { [key: string]: boolean };
    }
}
