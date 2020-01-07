import ActivityStore from './activityStore';
import UserStore from './userStore';
import { createContext } from 'react';
import { configure } from 'mobx';

configure({ enforceActions: "always" });

export class RootStore {
    constructor()
    {
        this.activityStore = new ActivityStore(this);
        this.userStore = new UserStore(this);
    }

    activityStore: ActivityStore;
    userStore: UserStore;
}

export const RootStoreContext = createContext(new RootStore());