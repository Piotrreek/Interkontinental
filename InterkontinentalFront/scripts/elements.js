export let newGameContent 
export let newGameDiv 
export let endGameDiv
export let mainHeader 
export let statistics 
export let newGameButton
export let loadMoreStatisticsBtn
export let loadMoreStatisticsDiv
export let loadAllStatisticsBtn
export let goTop
export let container

export const loadElements = () => {
    newGameContent = document.querySelector('.add-new-game__content')
    newGameDiv = document.querySelector('.add-new-game__button')
    endGameDiv = document.querySelector('.end-new-game__button')
    mainHeader = document.querySelector('.page__header')
    statistics = document.querySelector('.game-statistics')
    newGameButton = document.querySelector('.add-new-game')
    loadMoreStatisticsBtn = document.querySelector('.load-more-statistics-btn')
    loadMoreStatisticsDiv = document.querySelector('.load-more-statistics-div')
    loadAllStatisticsBtn = document.querySelector('.load-all-statistics-btn')
    goTop = document.querySelector('.go-top')
    container = document.querySelector('.container')
}