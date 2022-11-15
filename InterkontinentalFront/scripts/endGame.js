import { end } from "./api.js"
import { newGameDiv, endGameDiv, newGameContent, loadAllStatisticsBtn, loadMoreStatisticsBtn } from "./elements.js"
import { showDefaultStatistics } from "./statistics.js"
import {setMainHeader} from './index.js'

export const endGame = async (gameIdentifier) => {
    setMainHeader('Interkontinental')
    newGameDiv.classList.toggle('hide')
    endGameDiv.classList.toggle('hide')
    loadAllStatisticsBtn.classList.remove('hide')
    loadMoreStatisticsBtn.classList.remove('hide')
    newGameContent.innerText = ''
    newGameContent.classList.toggle('hide')
    showDefaultStatistics()
    const endResponse = await end(gameIdentifier)

    return 1
}