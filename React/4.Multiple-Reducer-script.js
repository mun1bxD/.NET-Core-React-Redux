import { combineReducers, createStore } from "redux";
import { wishReducers } from "./4.wishListReducer";
import { cardReducers } from "./cardItemReducers";
import { productReducer } from "./4.productListReducer";
import {
  CART_ADD_ITEM,
  CART_REMOVE_ITEM,
  CART_INCREASE_ITEM,
} from "./cardItemReducers";

import { WISH_ADD_ITEM, WISH_REMOVE_ITEM } from "./4.wishListReducer";

const reducers = combineReducers({
  product: productReducer,
  cardItem: cardReducers,
  wishList: wishReducers,
});

console.log(reducers);
store = createStore(
  reducers,
  window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__()
);

store.dispatch({
  type: CART_ADD_ITEM,
  payload: { productId: 1, quantity: 1 },
});
// we are able to add a new item only when we spread already created state...shown in condition
//"add/Item"
store.dispatch({
  type: CART_ADD_ITEM,
  payload: { productId: 11, quantity: 1 },
});
store.dispatch({
  type: CART_ADD_ITEM,
  payload: { productId: 12, quantity: 1 },
});
store.dispatch({
  type: CART_REMOVE_ITEM,
  payload: { productId: 11 },
});

store.dispatch({
  type: CART_INCREASE_ITEM,
  payload: { productId: 12, increment: 10 },
});
store.dispatch({
  type: WISH_ADD_ITEM,
  payload: { productId: 11 },
});

store.dispatch({
  type: WISH_ADD_ITEM,
  payload: { productId: 12, quantity: 1 },
});
store.dispatch({
  type: WISH_ADD_ITEM,
  payload: { productId: 12, quantity: 1 },
});
store.dispatch({
  type: WISH_REMOVE_ITEM,
  payload: { productId: 12, quantity: 1 },
});
