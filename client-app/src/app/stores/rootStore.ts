import ActivityStore from './activityStore';
import UserStore from './userStore';
import { createContext } from 'react';
import { configure } from 'mobx';
import CommonStore from './commonStore';

configure({ enforceActions: "always" });

export class RootStore {
    constructor()
    {
        this.activityStore = new ActivityStore(this);
        this.userStore = new UserStore(this);
        this.commonStore = new CommonStore(this);
    }

    activityStore: ActivityStore;
    userStore: UserStore;
    commonStore: CommonStore;
}

export const RootStoreContext = createContext(new RootStore());